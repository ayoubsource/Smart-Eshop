﻿using Microsoft.EntityFrameworkCore;
using MyEshop.Models.Entities;

namespace MyEshop.Models.DAO
{
    public class SmartEshopDbContext:DbContext
    {
        public SmartEshopDbContext(DbContextOptions<SmartEshopDbContext> options)
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
