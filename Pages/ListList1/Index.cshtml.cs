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
    public class IndexModel : PageModel
    {
        private readonly zad3FizzBuzzWebApp.Data.HistoryContext _context;

        public IndexModel(zad3FizzBuzzWebApp.Data.HistoryContext context)
        {
            _context = context;
        }

        public IList<List1> List1 { get;set; }

        public async Task OnGetAsync()
        {
            List1 = await _context.List1.ToListAsync();
        }
    }
}
