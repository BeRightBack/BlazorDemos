using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorLocalizationDemo.Entity;
public partial class StringResource
{
    public Guid Id { get; set; } = Guid.NewGuid();
    [NotMapped]
    public bool Selected { get; set; } = false;
    public Guid LanguageId { get; set; }
    public required string Name { get; set; }
    public required string Value { get; set; }

    public virtual Language? Language { get; set; }
}
