using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesLab.Data;
using RazorPagesLab.Models;

namespace RazorPagesLab.Pages_GroceryLists
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesLab.Data.RazorPagesLabContext _context;

        public CreateModel(RazorPagesLab.Data.RazorPagesLabContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public GroceryList GroceryList { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.GroceryList.Add(GroceryList);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
