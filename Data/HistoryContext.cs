using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using zad3FizzBuzzWebApp.Models;

namespace zad3FizzBuzzWebApp.Data
{
    public class HistoryContext : DbContext
    {
        public HistoryContext(DbContextOptions options) : base(options) { }
        public DbSet<List1> List1 { get; set; }

    }
}
