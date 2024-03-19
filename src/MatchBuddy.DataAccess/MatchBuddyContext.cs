using MatchBuddy.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection;

namespace MatchBuddy.DataAccess
{
    public class MatchBuddyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MatchBuddy;Trusted_Connection=true");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Stadium> Stadiums { get; set; }
        public DbSet<Match> Match { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<MatchComment> MatchComment { get; set; }

    }
}
