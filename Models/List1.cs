using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace zad3FizzBuzzWebApp.Models
{
    public class List1
    {
        public int Id { get; set; }

        [Display(Name = "Number"), Required, Range(1, 1000)]
        public int Num { get; set; }

        [MaxLength(100)]
        public string Outcome { get; set; }

        [MaxLength(100)]
        public string date { get; set; }
    }
}
