using BlazorLayoutDemo.Entity;

namespace BlazorLayoutDemo.Services;

public interface ILanguageService
{
    IEnumerable<Language> GetLanguages();
    Language GetLanguageByCulture(string culture);
}
