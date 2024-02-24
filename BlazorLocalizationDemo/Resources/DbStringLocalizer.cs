
using BlazorLocalizationDemo.Data;
using BlazorLocalizationDemo.Entity;
using BlazorLocalizationDemo.Services;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using System.Globalization;

namespace Resources;
public class DbStringLocalizer<T> : IStringLocalizer<T>
{
    public static HttpContext HttpContext => new HttpContextAccessor().HttpContext!;
    private readonly LocalizationDbContext _context;
    private readonly IList<CultureInfo> _supportedCultures;

    public DbStringLocalizer(LocalizationDbContext context, IOptions<RequestLocalizationOptions> localizationOptions)
    {
        _context = context;
        _supportedCultures = localizationOptions.Value.SupportedCultures!;
    }

    public LocalizedString this[string name]
    {
        get
        {
            // Resolve Services
            ILanguageService _languageService = (ILanguageService)HttpContext.RequestServices.GetService(typeof(ILanguageService))!;
            ILocalizationService _localizationService = (ILocalizationService)HttpContext.RequestServices.GetService(typeof(ILocalizationService))!;

            var currentCulture = Thread.CurrentThread.CurrentUICulture.Name;

            var language = _languageService?.GetLanguageByCulture(currentCulture);
            if (language == null)
            {
                language = _languageService?.GetLanguages().FirstOrDefault();
            }
            
            if (language != null)
            {
                var stringResource = _localizationService?.GetStringResource(name, language.Id);

                if (stringResource != null && !string.IsNullOrEmpty(stringResource.Value))
                {
                    return new LocalizedString(name, stringResource?.Value ?? name, stringResource?.Value == null);
                }

                if (stringResource == null || string.IsNullOrEmpty(stringResource.Value))
                {
                    foreach (var item in _supportedCultures)
                    {
                        var languageId = _languageService?.GetLanguageByCulture(item.Name)?.Id;
                        var _resource = new StringResource
                        {
                            LanguageId = (Guid)languageId!,
                            Name = name,
                            Value = name + "-" + item.NativeName
                        };
                        _localizationService?.AddOrUpdateStringResource(_resource);
                    }

                    return new LocalizedString(name, stringResource?.Value ?? name, stringResource?.Value == null);
                }
                //return new LocalizedString(name, stringResource?.Value ?? name, stringResource?.Value == null);
            }
           return new LocalizedString(name, name, true);
        }
    }

    public LocalizedString this[string name, params object[] arguments] => this[name];

    public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures) => _context.StringResources.Select(e => new LocalizedString(e.Name, e.Value));

    public IStringLocalizer WithCulture(CultureInfo culture) => this;
}