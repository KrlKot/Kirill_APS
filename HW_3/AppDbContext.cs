using Homework3.HW_3;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Homework3
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Player> Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { optionsBuilder.UseSqlite("Data Source = football.db"); }
        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Player>().
                HasOne(x => x.Club).
                WithMany(x => x.Players).
                HasForeignKey(x => x.ClubId);
        }
    }
}
