using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Juliusz_Final.Models;
using Microsoft.EntityFrameworkCore;

namespace Juliusz_Final.Context
{
    public class EFCDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=SkiRent;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
