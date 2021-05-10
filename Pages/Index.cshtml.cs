using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zad3FizzBuzzWebApp.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;
using zad3FizzBuzzWebApp.Data;

namespace zad3FizzBuzzWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public List1 list1 { get; set; }
        private readonly HistoryContext _context;
        public IList<List1> History { get; set; }
        public IndexModel(ILogger<IndexModel> logger, HistoryContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            History = _context.List1.ToList();
        }

        /*public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                list1.date = DateTime.UtcNow.ToString("MM-dd-yyyy");
                if (list1.Num % 15 == 0)
                    list1.Outcome = "Otrzymano: FizzBuzz";

                else if (list1.Num % 5 == 0)
                    list1.Outcome = "Otrzymano: Buzz";

                else if (list1.Num % 3 == 0)
                    list1.Outcome = "Otrzymano: Fizz";

                else
                    list1.Outcome = "Liczba: " + list1.Num + " nie spełnia kryteriów Fizz / Buzz";
                
                HttpContext.Session.SetString("SessionAddress", JsonConvert.SerializeObject(list1));
                _context.List1.Add(list1);
                return Page();
            }
            return Page();
        }*/
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                list1.date = DateTime.UtcNow.ToString("dd-MM-yyyy");
                if (list1.Num % 15 == 0)
                    list1.Outcome = "Otrzymano: FizzBuzz";

                else if (list1.Num % 5 == 0)
                    list1.Outcome = "Otrzymano: Buzz";

                else if (list1.Num % 3 == 0)
                    list1.Outcome = "Otrzymano: Fizz";

                else
                    list1.Outcome = "Liczba: " + list1.Num + " nie spełnia kryteriów Fizz / Buzz";

                HttpContext.Session.SetString("SessionAddress", JsonConvert.SerializeObject(list1));
                _context.List1.Add(list1);
                await _context.SaveChangesAsync();
                return Page();
            }

            

            return Page();
        }
    }
}
