using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesLab.Models;

public class GroceryList
{
    public int Id { get; set; }

    [StringLength(60, MinimumLength = 2)]
    [Required]
    public required string Name { get; set; }

    [Display(Name = "Date Purchased")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    [Required]
    public DateTime DateBought { get; set; }

    [Display(Name = "Buy Again?")]
    public bool Rebuy { get; set; }

    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Price { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [Display(Name = "Bought From")]
    public string? Store { get; set; } = string.Empty;
}