using Microsoft.EntityFrameworkCore;
using Opdracht2_Adam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Opdracht2_Adam.db
{
    public class OpdrachtDBContext : DbContext
    {
        public DbSet<Persoon> Personen { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<House> Houses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
          => options.UseSqlite("Data Source=OpdrachtDeel2.db");
    }
}
