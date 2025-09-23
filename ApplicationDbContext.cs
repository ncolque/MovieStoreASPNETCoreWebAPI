using Microsoft.EntityFrameworkCore;
using MovieStoreASPNETCoreWebAPI.Entities;

namespace MovieStoreASPNETCoreWebAPI
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Genero>().HasKey(g => g.Id);
            modelBuilder.Entity<Genero>().Property(g => g.Nombre).HasMaxLength(150);

            modelBuilder.Entity<Actor>().Property(a => a.Nombre).HasMaxLength(150);
            modelBuilder.Entity<Actor>().Property(a => a.FechaNacimiento).HasColumnType("date");
            modelBuilder.Entity<Actor>().Property(a => a.Fortuna).HasPrecision(18, 2);
        }

        public DbSet<Genero> Generos => Set<Genero>();
        public DbSet<Actor> Actores => Set<Actor>();
    }
}
