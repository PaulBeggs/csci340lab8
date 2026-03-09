using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesLab.Data;
using RazorPagesLab.Models;

namespace RazorPagesLab.Pages_GroceryLists
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesLab.Data.RazorPagesLabContext _context;

        public IndexModel(RazorPagesLab.Data.RazorPagesLabContext context)
        {
            _context = context;
        }

        public IList<GroceryList> GroceryList { get;set; } = default!;

        public async Task OnGetAsync()
        {
            GroceryList = await _context.GroceryList.ToListAsync();
        }
    }
}
