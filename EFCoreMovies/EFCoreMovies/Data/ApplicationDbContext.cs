using EFCoreMovies.Entities;
using EFCoreMovies.Entities.Configuration;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMovies.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
            configurationBuilder.Properties<String>().HaveMaxLength(150);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            

            

            

            

            

            
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
