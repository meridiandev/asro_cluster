using Microsoft.EntityFrameworkCore;
using asro_api.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asro_api.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<thReports_1_Teacher>()
                .HasOne(b => b.thReports_1)
                .WithMany(ba => ba.thReports_1_Teacher)
                .HasForeignKey(bi => bi.thReports_1Id);
            
            modelBuilder.Entity<thReports_1_Teacher>()
                .HasOne(b => b.Teacher)
                .WithMany(ba => ba.thReports_1_Teacher)
                .HasForeignKey(bi => bi.TeacherId);
        }

        public DbSet<thReports_1> thReports_1 { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<thReports_1_Teacher> thReports_1_Teacher { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}
