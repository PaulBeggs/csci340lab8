using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesLab.Data;
using RazorPagesLab.Models;

namespace RazorPagesLab.Pages_GroceryLists
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesLab.Data.RazorPagesLabContext _context;

        public EditModel(RazorPagesLab.Data.RazorPagesLabContext context)
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

            var grocerylist =  await _context.GroceryList.FirstOrDefaultAsync(m => m.Id == id);
            if (grocerylist == null)
            {
                return NotFound();
            }
            GroceryList = grocerylist;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(GroceryList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroceryListExists(GroceryList.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool GroceryListExists(int id)
        {
            return _context.GroceryList.Any(e => e.Id == id);
        }
    }
}
