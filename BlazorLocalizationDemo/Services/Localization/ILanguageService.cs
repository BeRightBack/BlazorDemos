using BlazorLocalizationDemo.Data.Entity.Localization;

namespace BlazorLocalizationDemo.Services.Localization;

public interface ILanguageService
{
    IEnumerable<Language> GetLanguages();
    Language GetLanguageByCulture(string culture);
}
