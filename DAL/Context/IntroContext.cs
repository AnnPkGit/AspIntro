using Intro.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Intro.DAL.Context
{
    public class IntroContext : DbContext 
    {
        public DbSet<User> Users { get; set; }

        public IntroContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsersConfiguration());  
        }
    }
}
