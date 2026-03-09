using Microsoft.EntityFrameworkCore;
using RazorPagesLab.Data;

namespace RazorPagesLab.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPagesLabContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesLabContext>>()))
        {
            if (context == null || context.GroceryList == null)
            {
                throw new ArgumentNullException("Null RazorPagesLabContext");
            }

            // Look for any lists.
            if (context.GroceryList.Any())
            {
                return;   // DB has been seeded
            }

            context.GroceryList.AddRange(
                new GroceryList
                {
                    Name = "Avocados",
                    DateBought = DateTime.Parse("2026-2-12"),
                    Rebuy = true,
                    Price = 7.99M
                },
                new GroceryList
                {
                    Name = "Bread",
                    DateBought = DateTime.Parse("2026-2-12"),
                    Rebuy = false,
                    Price = 2.39M
                }
            );
            context.SaveChanges();
        }
    }
}