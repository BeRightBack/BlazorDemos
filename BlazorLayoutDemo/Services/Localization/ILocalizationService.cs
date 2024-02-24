using BlazorLayoutDemo.Entity;

namespace BlazorLayoutDemo.Services;

public interface ILocalizationService
{
    StringResource GetStringResource(string resourceKey, Guid languageId);
    void AddOrUpdateStringResource(StringResource resource);
}
