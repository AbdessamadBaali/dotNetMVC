using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class PurchaseDto 
{
    [Key]
    public int PurchaseId { get; set; } // Primary Key

    [Required]
    public string Name { get; set; } // Name of the purchase, assuming this is a descriptive field

    [Required]
    public int ProductId { get; set; } // Foreign Key to Product entity
    [ForeignKey("ProductId")]
    public virtual Product Product { get; set; } // Navigation property to Product

    [Required]
    public int UserId { get; set; } // Foreign Key to User entity
    [ForeignKey("UserId")]
    public virtual User User { get; set; } // Navigation property to User

    [Required]
    public DateTime Date { get; set; } // Date of the purchase

    [Required]
    public int Quantity { get; set; } // Quantity of the product purchased
}
