using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkshopAsp.Models.DomainModel
{
    public class WorkshopContext : DbContext
    {
        public WorkshopContext(DbContextOptions<WorkshopContext> options) : base(options) { }

        public DbSet <Owner> Owners { get; set; }
    }
}
