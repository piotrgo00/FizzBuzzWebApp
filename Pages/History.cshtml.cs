using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using zad3FizzBuzzWebApp.Data;
using zad3FizzBuzzWebApp.Models;

namespace zad3FizzBuzzWebApp.Pages
{
    public class HistoryModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly HistoryContext _context;
        public IList<List1> History { get; set; }
        public HistoryModel(ILogger<IndexModel> logger, HistoryContext context)
        {
            _logger = logger;
            _context = context;
        }
        public void OnGet()
        {
            var HistoryQuery = (from List1 in _context.List1
                                orderby List1.Id descending
                                select List1).Take(10);
            History = HistoryQuery.ToList();
        }
    }
}
