using System.ComponentModel.DataAnnotations;

namespace AspNet_Assignment.Models.Products
{
    public class ProductEntity
    {
        [Key]
        public string SKU { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string Price { get; set; } = null!;
        public string? ImageUrl { get; set; }
    }
}
