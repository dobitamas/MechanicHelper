using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MechanicHelper.Models
{
    public class MechanicDbContext : DbContext
    {
        public virtual DbSet<Car> Cars { get; set; }

        public MechanicDbContext(DbContextOptions<MechanicDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Car>()
                .HasMany(c => c.Repairs)
                .WithOne(r => r.ServicedOn);
        }
    }
}