using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyEshop.Models
{
    class DBContext:DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
           : base(options)
        {

        }
        // parcourir les tables avec le dbSet
        public DbSet<Account> Account { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
