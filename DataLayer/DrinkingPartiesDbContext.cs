using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DrinkingPartiesDbContext : DbContext
    {
        public DrinkingPartiesDbContext()
        {

        }

        public DrinkingPartiesDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-C95UOLC\SQLEXPRESS;Database=DrinkingPartiesDB;Trusted_Connection=True");
            }
        }

        public DbSet<Alcohol> Alcohols { get; set; }

        public DbSet<Alcoholic> Alcoholics { get; set; }

        public DbSet<Party> Parties { get; set; }
    }
}