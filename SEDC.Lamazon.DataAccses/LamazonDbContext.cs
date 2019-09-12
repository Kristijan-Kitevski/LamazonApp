using Microsoft.EntityFrameworkCore;
using SEDC.Lamzaon.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.DataAccses
{
    public class LamazonDbContext:DbContext
    {
        public LamazonDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> products { get; set; }

        public DbSet<OrderProduct> GetOrderProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBilder)
        {
            base.OnModelCreating(modelBilder);

            modelBilder.Entity<OrderProduct>()
                .HasKey(po => new { po.ProductId, po.OrderId });

            modelBilder.Entity<Role>()
                .HasMany(r => r.Users)
                .WithOne(u => u.Role)
                .HasForeignKey(u => u.RoleId);

            modelBilder.Entity<User>()
                .HasMany(u => u.Orders)
                .WithOne(o => o.User)
                .HasForeignKey(o => o.UserId);

            modelBilder.Entity<Order>()
                .HasMany(o => o.ProductOrders)
                .WithOne(op => op.Order)
                .HasForeignKey(op => op.OrderId);

            modelBilder.Entity<Product>()
                .HasMany(p => p.OrderProduct)
                .WithOne(po => po.Product)
                .HasForeignKey(po => po.ProductId);

            
                
        }
    }
}
