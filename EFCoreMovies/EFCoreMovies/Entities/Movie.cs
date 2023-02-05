namespace EFCoreMovies.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool InCinema { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string PosterURL { get; set; }
        public HashSet<CinemaHall> Genres { get; set; }
        public HashSet<CinemaHall> CinemaHalls { get; set; }
        public HashSet<MovieActor> MoviesActors { get; set; }
    }
}
