using BlazorLocalizationDemo.Data.Entity.Localization;

namespace BlazorLocalizationDemo.Services.Localization;

public interface ILocalizationService
{
    StringResource GetStringResource(string resourceKey, Guid languageId);
    void AddOrUpdateStringResource(StringResource resource);
}
