using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorLocalizationDemo.Data.Entity.Localization;
public partial class Language
{
    public Language()
    {
        StringResources = new HashSet<StringResource>();
    }

    public Guid Id { get; set; } = Guid.NewGuid();
    [NotMapped]
    public bool Selected { get; set; } = false;
    public required string Name { get; set; } = string.Empty;
    public required string Culture { get; set; } = string.Empty;

    public virtual ICollection<StringResource> StringResources { get; set; }
}
