using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using zad3FizzBuzzWebApp.Data;
using zad3FizzBuzzWebApp.Models;

namespace zad3FizzBuzzWebApp.Pages.ListList1
{
    public class CreateModel : PageModel
    {
        private readonly zad3FizzBuzzWebApp.Data.HistoryContext _context;

        public CreateModel(zad3FizzBuzzWebApp.Data.HistoryContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public List1 List1 { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.List1.Add(List1);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
