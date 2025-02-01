using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseAPI.Models
{
    public class Product
    {
        [Key]  // Primary Key
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty; // Example: "Big Cola 3L"

        public string? Description { get; set; }

        [Required]
        public string Category { get; set; } = "General"; // Example: "Soft Drink", "Electronics", "Clothing"

        [Required]
        public string SubCategory { get; set; } = "Uncategorized"; // Example: "Cola", "Mobile", "T-shirt"

        [Required]
        public int Quantity { get; set; }  // Stock count

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }  // Price per unit

        [Required]
        public string Unit { get; set; } = "Piece"; // Example: "Litre", "Kg", "Piece"

        public string? Brand { get; set; } // Example: "Big Cola", "Samsung", "Nike"

        public string? SKU { get; set; } // Stock Keeping Unit - Unique Identifier

        public string? Barcode { get; set; } // Optional Barcode/QR code

        public DateTime? ExpiryDate { get; set; } // Useful for perishable products

        public bool IsActive { get; set; } = true; // Can be used for soft delete or availability

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
