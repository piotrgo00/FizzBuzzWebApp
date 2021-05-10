using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using zad3FizzBuzzWebApp.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace zad3FizzBuzzWebApp.Pages
{
    public class ListModel : PageModel
    {
        //public List<List1> lista = new List<List1>();
        public List1 list { get; set; }
        public void OnGet()
        {
            var SessionAddress = HttpContext.Session.GetString("SessionAddress");
            if (SessionAddress != null)
            {
                list = JsonConvert.DeserializeObject<List1>(SessionAddress);
                //lista.Add(list);
            }
                
        }
    }
}
