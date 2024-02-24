namespace BlazorLayoutDemo.Entity;

public class ProductSpecificationMapping
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid SpecificationId { get; set; }
    public string Value { get; set; }
    public int SortOrder { get; set; }
    public int Position { get; set; }

    public virtual Product Product { get; set; }
    public virtual Specification Specification { get; set; }
}
