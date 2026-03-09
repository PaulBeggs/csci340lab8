using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesLab.Models;

namespace RazorPagesLab.Data
{
    public class RazorPagesLabContext : DbContext
    {
        public RazorPagesLabContext (DbContextOptions<RazorPagesLabContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesLab.Models.GroceryList> GroceryList { get; set; } = default!;
    }
}
