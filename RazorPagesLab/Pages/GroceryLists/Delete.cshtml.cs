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
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesLab.Data.RazorPagesLabContext _context;

        public DeleteModel(RazorPagesLab.Data.RazorPagesLabContext context)
        {
            _context = context;
        }

        [BindProperty]
        public GroceryList GroceryList { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grocerylist = await _context.GroceryList.FirstOrDefaultAsync(m => m.Id == id);

            if (grocerylist is not null)
            {
                GroceryList = grocerylist;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grocerylist = await _context.GroceryList.FindAsync(id);
            if (grocerylist != null)
            {
                GroceryList = grocerylist;
                _context.GroceryList.Remove(GroceryList);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
