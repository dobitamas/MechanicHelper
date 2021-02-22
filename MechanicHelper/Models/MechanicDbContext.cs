using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MechanicHelper.Models
{
    public class MechanicDbContext : DbContext
    {
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<RepairService> RepairServices { get; set; }

        public virtual DbSet<Problem> Problems { get; set; }

        public MechanicDbContext(DbContextOptions<MechanicDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Car Car1 = new Car(-1, "Alfa", "Romeo", DateTime.Now, 20000);
            Car Car2 = new Car(-2, "Alfa", "Romeo", DateTime.Now, 20000);
            Car Car3 = new Car(-3, "Alfa", "Romeo", DateTime.Now, 20000);

            List<Car> CreatedCars = new List<Car>();
            CreatedCars.Add(Car1);
            CreatedCars.Add(Car2);
            CreatedCars.Add(Car3);

            base.OnModelCreating(builder);

            builder.Entity<Car>()
                .HasMany(c => c.Repairs)
                .WithOne(r => r.ServicedOn);

            builder.Entity<RepairService>()
                .HasOne(c => c.ServicedOn);

            builder.Entity<Problem>()
                .HasOne(p => p.ProblemOn);

            builder.Entity<Car>()
                .HasData(CreatedCars);
        }
    }
}