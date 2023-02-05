using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreMovies.Entities.Configuration
{
    public class GenreConfig : IEntityTypeConfiguration<CinemaHall>
    {
        public void Configure(EntityTypeBuilder<CinemaHall> builder)
        {
            builder.Property(p => p.Name).IsRequired();
        }
    }
}
