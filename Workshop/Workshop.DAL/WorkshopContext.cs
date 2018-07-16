using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Workshop.Models.Entities;

namespace Workshop.DAL
{
    public class WorkshopContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Owner> Owners { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if(!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-GTPU7TI\SQLEXPRESS;Database=WorkshopAsp;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
