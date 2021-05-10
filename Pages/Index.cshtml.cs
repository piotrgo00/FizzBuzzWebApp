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

namespace zad3FizzBuzzWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public List1 list1 { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                list1.date = DateTime.UtcNow.ToString("MM-dd-yyyy");
                list1.czyFB = false;
                if (list1.Num % 15 == 0)
                    list1.Outcome = "Otrzymano: FizzBuzz";

                else if (list1.Num % 5 == 0)
                    list1.Outcome = "Otrzymano: Buzz";

                else if (list1.Num % 3 == 0)
                    list1.Outcome = "Otrzymano: Fizz";

                else
                    list1.Outcome = "Liczba: " + list1.Num + " nie spełnia kryteriów Fizz / Buzz";
                
                HttpContext.Session.SetString("SessionAddress", JsonConvert.SerializeObject(list1));
                return Page();
            }
            return Page();
        }
    }
}
