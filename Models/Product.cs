using System.ComponentModel.DataAnnotations;

namespace ProductManagementNet.Models;

public class Product
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Product name is required.")]
    [StringLength(120)]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Description is required.")]
    [StringLength(500)]
    public string Description { get; set; } = string.Empty;

    [Range(0, 999999999, ErrorMessage = "Price must be 0 or greater.")]
    public decimal Price { get; set; }
}
