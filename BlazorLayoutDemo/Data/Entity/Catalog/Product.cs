using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorLayoutDemo.Entity;

public class Product
{
    public Guid Id { get; set; }
    [NotMapped]
    public bool Selected { get; set; } = false;
    public string Name { get; set; }
    public decimal CostPrice { get; set; }
    public decimal RetailPrice { get; set; }
    public string SKU { get; set; }
    public string ShortDescription { get; set; }
    public string Description { get; set; }
    public decimal? SpecialPrice { get; set; }
    public DateTime? SpecialPriceStartDate { get; set; }
    public DateTime? SpecialPriceEndDate { get; set; }

    public int StockQuantity { get; set; }
    public int MinimumStockQuantity { get; set; }
    public int NotifyForQuantityBelow { get; set; }
    public bool DisplayAvailability { get; set; }
    public int MinimumCartQuantity { get; set; }
    public int MaximumCartQuantity { get; set; }

    public string SeoUrl { get; set; }
    public string MetaTitle { get; set; }
    public string MetaKeywords { get; set; }
    public string MetaDescription { get; set; }

    public bool Published { get; set; }
    public DateTime DateAdded { get; set; }
    public DateTime DateModified { get; set; }

    public virtual ICollection<ProductCategoryMapping> Categories { get; set; }
    public virtual ICollection<ProductImageMapping> Images { get; set; }
    public virtual ICollection<ProductManufacturerMapping> Manufacturers { get; set; }
    public virtual ICollection<ProductSpecificationMapping> Specifications { get; set; }
}
