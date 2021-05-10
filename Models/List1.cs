using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace zad3FizzBuzzWebApp.Models
{
    public class List1
    {
        [Display(Name = "Number"), Required, Range(1, 1000)]
        public int Num { get; set; }
        public string Outcome { get; set; }
        public bool czyFB { get; set; }
        [Display(Name = "Date")]
        public string date { get; set; }
    }
}
