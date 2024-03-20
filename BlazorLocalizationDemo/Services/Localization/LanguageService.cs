using BlazorLocalizationDemo.Data;
using BlazorLocalizationDemo.Data.Entity.Localization;

namespace BlazorLocalizationDemo.Services.Localization;
public class LanguageService : ILanguageService
{
    private readonly LocalizationDbContext _context;

    public LanguageService(LocalizationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Language> GetLanguages()
    {
        return _context.Languages.ToList();
    }

    public Language GetLanguageByCulture(string culture)
    {
        return _context.Languages.FirstOrDefault(x =>
            x.Culture.Trim().ToLower() == culture.Trim().ToLower())!;
    }
}