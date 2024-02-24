using BlazorLocalizationDemo.Data;
using BlazorLocalizationDemo.Entity;

namespace BlazorLocalizationDemo.Services;
public class LocalizationService : ILocalizationService
{
    private readonly LocalizationDbContext _context;

    public LocalizationService(LocalizationDbContext context)
    {
        _context = context;
    }

    public StringResource GetStringResource(string resourceKey, Guid languageId)
    {
        return _context.StringResources.FirstOrDefault(x =>
                x.Name.Trim().ToLower() == resourceKey.Trim().ToLower()
                && x.LanguageId == languageId)!;
    }

    public void AddOrUpdateStringResource(StringResource resource)
    {
        lock (_context)
        {
            _context.Add(resource);
            _context.SaveChanges();
        }
    }
}
