using BlazorLocalizationDemo.Data;
using Microsoft.Extensions.Options;
using System.Globalization;

namespace BlazorLocalizationDemo.Configuration;
public class SeedLanguage
{
    private readonly LocalizationDbContext _context;
    private readonly IList<CultureInfo> _supportedCultures;

    public SeedLanguage(LocalizationDbContext context, IOptions<RequestLocalizationOptions> localizationOptions)
    {
        _context = context;
        _supportedCultures = localizationOptions.Value.SupportedCultures!;
    }

    public async Task EnsureSeedLanguageAsync()
    {
        if (_context == null)
        {
            throw new ArgumentNullException(nameof(_context));
        }

        if (_context.Languages.Any())
        {
            return;
        }

        if (_supportedCultures == null)
        {
            throw new ArgumentNullException(nameof(_supportedCultures));
        }

        foreach (var culture in _supportedCultures)
        {
            var language = new Entity.Language
            {
                Id = Guid.NewGuid(),
                Name = culture.DisplayName,
                Culture = culture.ToString()
            };

            _context.Languages.Add(language);
        }

        await _context.SaveChangesAsync();
    }
}
