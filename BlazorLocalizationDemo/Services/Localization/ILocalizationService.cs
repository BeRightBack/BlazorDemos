using BlazorLocalizationDemo.Entity;

namespace BlazorLocalizationDemo.Services;

public interface ILocalizationService
{
    StringResource GetStringResource(string resourceKey, Guid languageId);
    void AddOrUpdateStringResource(StringResource resource);
}
