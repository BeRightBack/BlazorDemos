namespace BlazorLocalizationDemo.Services;

public interface ILanguageService
{
    IEnumerable<Language> GetLanguages();
    Language GetLanguageByCulture(string culture);
}
