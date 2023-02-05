using EFCoreMovies.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMovies.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Actor>().Property(p => p.Name).HasMaxLength(150).IsRequired();
            modelBuilder.Entity<Actor>().Property(p => p.DateOfBirth).HasColumnType("date");

            modelBuilder.Entity<Cinema>().Property(p => p.Name).HasMaxLength(150).IsRequired();

            modelBuilder.Entity<CinemaHall>().Property(p => p.Cost).HasPrecision(9, 2);
            modelBuilder.Entity<CinemaHall>().Property(p => p.CinemaHallType).HasDefaultValue(CinemaHallType.TwoDimensions);

            modelBuilder.Entity<CinemaOffer>().Property(p => p.Begin).HasColumnType("date");
            modelBuilder.Entity<CinemaOffer>().Property(p => p.End).HasColumnType("date");
            modelBuilder.Entity<CinemaOffer>().Property(p => p.DiscountPercentage).HasPrecision(5, 2);

            modelBuilder.Entity<Genre>().Property(p => p.Name).HasMaxLength(150).IsRequired();

            modelBuilder.Entity<Movie>().Property(p => p.Title).HasMaxLength(250).IsRequired();
            modelBuilder.Entity<Movie>().Property(p => p.ReleaseDate).HasColumnType("date");
            modelBuilder.Entity<Movie>().Property(p => p.PosterURL).HasMaxLength(500).IsUnicode(false);

            modelBuilder.Entity<MovieActor>().HasKey(p => new { p.MovieId, p.ActorId });
            modelBuilder.Entity<MovieActor>().Property(p => p.Character).HasMaxLength(150);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<CinemaHall> CinemaHalls { get; set; }
        public DbSet<CinemaOffer> CinemaOffers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieActor> MoviesActors { get; set; }

    }
}
