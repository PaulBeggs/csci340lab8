using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesLab.Data;
using RazorPagesLab.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.CodeAnalysis.Scripting.Hosting;

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

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? DateBought { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime? GroceryListDateBought { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<DateTime?> dateTimes = from l in _context.GroceryList
                                             orderby l.DateBought ascending
                                             select l.DateBought;

            var produce = from i in _context.GroceryList
                          select i;
            if (!string.IsNullOrEmpty(SearchString))
            {
                produce = produce.Where(s => s.Name.Contains(SearchString));
            }

            if (GroceryListDateBought.HasValue)
            {
                produce = produce.Where(x => x.DateBought == GroceryListDateBought);
            }
            DateBought = new SelectList(await dateTimes.Distinct().ToListAsync());
            GroceryList = await produce.ToListAsync();
        }
    }
}
