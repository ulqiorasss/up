using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Testik.Models;

namespace lera_dem.Database
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Lerassk");

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product_category> Product_Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Combo> Combos { get; set; }
        public DbSet<Combo_product> Combo_Products { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
