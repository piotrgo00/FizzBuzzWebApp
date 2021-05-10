using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using zad3FizzBuzzWebApp.Data;
using zad3FizzBuzzWebApp.Models;

namespace zad3FizzBuzzWebApp.Pages.ListList1
{
    public class EditModel : PageModel
    {
        private readonly zad3FizzBuzzWebApp.Data.HistoryContext _context;

        public EditModel(zad3FizzBuzzWebApp.Data.HistoryContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(List1).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!List1Exists(List1.Id))
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

        private bool List1Exists(int id)
        {
            return _context.List1.Any(e => e.Id == id);
        }
    }
}
