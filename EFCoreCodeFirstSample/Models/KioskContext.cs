using Microsoft.EntityFrameworkCore;
using System;

namespace EFCoreCodeFirstSample.Models
{
    public class KioskContext : DbContext
    {
        public KioskContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Kiosk> Kiosks { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
