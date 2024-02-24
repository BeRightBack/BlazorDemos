using BlazorLayoutDemo.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorLayoutDemo.Data;

public class CatalogDbContext(DbContextOptions<CatalogDbContext> options) : DbContext(options)
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<Manufacturer> Manufacturers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductCategoryMapping> ProductCategoryMappings { get; set; }
    public DbSet<ProductImageMapping> ProductImageMappings { get; set; }
    public DbSet<ProductManufacturerMapping> ProductManufacturerMappings { get; set; }
    public DbSet<ProductSpecificationMapping> ProductSpecificationMappings { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Specification> Specifications { get; set; }

    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Category>().ToTable("Category");
        modelBuilder.Entity<Image>().ToTable("Image");
        modelBuilder.Entity<Manufacturer>().ToTable("Manufacturer");
        modelBuilder.Entity<Product>().ToTable("Product");
        modelBuilder.Entity<ProductCategoryMapping>().ToTable("ProductCategoryMapping");
        modelBuilder.Entity<ProductImageMapping>().ToTable("ProductImageMapping");
        modelBuilder.Entity<ProductManufacturerMapping>().ToTable("ProductManufacturerMapping");
        modelBuilder.Entity<ProductSpecificationMapping>().ToTable("ProductSpecificationMapping");
        modelBuilder.Entity<Review>().ToTable("Review");
        modelBuilder.Entity<Specification>().ToTable("Specification");
        modelBuilder.Entity<Book>().ToTable("Book");
    }


}