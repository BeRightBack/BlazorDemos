namespace BlazorLayoutDemo.Entity;

public class ProductManufacturerMapping
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid ManufacturerId { get; set; }

    public virtual Product? Product { get; set; }
    public virtual Manufacturer? Manufacturer { get; set; }
}
