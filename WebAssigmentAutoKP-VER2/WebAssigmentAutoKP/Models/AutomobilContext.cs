using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAssigmentAutoKP.Models
{
    public class AutomobilContext : DbContext
    {
        public readonly AutomobilContext db;
        public DbSet<Automobil> Automobili { get; set; }
        public AutomobilContext(DbContextOptions<AutomobilContext> opcije) : base(opcije)
        {

        }
    }
}
