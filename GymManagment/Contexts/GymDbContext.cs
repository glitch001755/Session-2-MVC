using GymManagment.Entites;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GymManagment.Contexts
{
    public class GymDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
              "Server=.;Database=GymDB;Trusted_Connection=True;TrustServerCertificate=True"
          );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Member> Members { get; set; }

        public DbSet<Trainer> Trainers { get; set; }

        public DbSet<Plan> Plans { get; set; }

        public DbSet<Session> Sessions { get; set; }
        public DbSet<Membership> Memberships { get; set; }
    }
}
