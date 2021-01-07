using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nume_Pren_Lab8.Models;

namespace Nume_Pren_Lab8.Data
{
    public class Nume_Pren_Lab8Context : DbContext
    {
        public Nume_Pren_Lab8Context (DbContextOptions<Nume_Pren_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Nume_Pren_Lab8.Models.Book> Book { get; set; }
    }
}
