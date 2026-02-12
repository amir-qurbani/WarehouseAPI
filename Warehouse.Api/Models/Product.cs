using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace WarehouseAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(100, ErrorMessage = "Product name cannot exceed 100 characters.")]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [Range(0, 1000000, ErrorMessage = "Price must be greater than zero.")]
        public decimal Price { get; set; }
        [Range(0, 1000000, ErrorMessage = "Stock quantity cannot be negative.")]
        public int StockQuantity { get; set; }
    }
}