namespace BlazorLayoutDemo.Entity;

public class ProductImageMapping
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid ImageId { get; set; }
    public int SortOrder { get; set; }
    public int Position { get; set; }

    public virtual Product? Product { get; set; }
    public virtual Image? Image { get; set; }
}
