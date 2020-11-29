using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Criste_Andrei_Lab8.wwwroot.Models;
using Criste_Andrei_Lab8.Models;

namespace Criste_Andrei_Lab8.Data
{
    public class Criste_Andrei_Lab8Context : DbContext
    {
        public Criste_Andrei_Lab8Context (DbContextOptions<Criste_Andrei_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Criste_Andrei_Lab8.wwwroot.Models.Book> Book { get; set; }

        public DbSet<Criste_Andrei_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Criste_Andrei_Lab8.Models.Category> Category { get; set; }
    }
}
