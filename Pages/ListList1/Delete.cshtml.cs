using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using zad3FizzBuzzWebApp.Data;
using zad3FizzBuzzWebApp.Models;

namespace zad3FizzBuzzWebApp.Pages.ListList1
{
    public class DeleteModel : PageModel
    {
        private readonly zad3FizzBuzzWebApp.Data.HistoryContext _context;

        public DeleteModel(zad3FizzBuzzWebApp.Data.HistoryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public List1 List1 { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            List1 = await _context.List1.FirstOrDefaultAsync(m => m.Id == id);

            if (List1 == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            List1 = await _context.List1.FindAsync(id);

            if (List1 != null)
            {
                _context.List1.Remove(List1);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
