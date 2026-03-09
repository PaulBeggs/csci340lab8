using System.ComponentModel.DataAnnotations;

namespace RazorPagesLab.Models;

public class GroceryList
{
    public int Id { get; set; }
    public string? Name { get; set; }
    [DataType(DataType.Date)]
    public DateTime DateBought { get; set; }
    public bool Rebuy { get; set; }
    public decimal Price { get; set; }
}