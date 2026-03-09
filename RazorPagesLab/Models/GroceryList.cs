using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesLab.Models;

public class GroceryList
{
    public int Id { get; set; }
    public string Name { get; set; }
    [Display(Name = "Date Purchased")]
    [DataType(DataType.Date)]
    public DateTime? DateBought { get; set; }
    [Display(Name = "Buy Again?")]
    public bool Rebuy { get; set; }
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
}