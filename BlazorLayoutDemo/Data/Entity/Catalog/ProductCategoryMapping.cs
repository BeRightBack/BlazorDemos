namespace BlazorLayoutDemo.Entity;

public class ProductCategoryMapping
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid CategoryId { get; set; }

    public virtual Product? Product { get; set; }
    public virtual Category? Category { get; set; }
}
