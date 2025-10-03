using Movie_Directory_with_ASP.NET_Core_MVC.Models;
using System.Globalization;
using Movie_Directory_with_ASP.NET_Core_MVC.Service;

namespace Movie_Directory_with_ASP.NET_Core_MVC.Models
{
    public class MovieServices :IMovieServices
    {
        //Lists all movies and its details
        private static readonly List<Movies> Movies = new List<Movies>
        {
            new Movies { Id = 1, Title = "Inception", Year = 2010, Genre = "Sci-Fi", Rating = 8.8m, Description = "A mind-bending thriller." },
            new Movies { Id = 2, Title = "The Matrix", Year = 1999, Genre = "Sci-Fi", Rating = 8.7m, Description = "Reality is not what it seems." },
            new Movies { Id = 3, Title = "Interstellar", Year = 2014, Genre = "Sci-Fi", Rating = 8.6m, Description = "Space travel and family." },
            new Movies { Id = 4, Title = "The Shawshank Redemption", Year = 1994, Genre = "Drama", Rating = 9.3m, Description = "Hope and friendship." },
            new Movies { Id = 5, Title = "The Godfather", Year = 1972, Genre = "Crime", Rating = 9.2m, Description = "Family and power." },
            new Movies { Id = 6, Title = "Pulp Fiction", Year = 1994, Genre = "Crime", Rating = 8.9m, Description = "Interwoven stories." },
            new Movies { Id = 7, Title = "Fight Club", Year = 1999, Genre = "Drama", Rating = 8.8m, Description = "Identity and chaos." },
            new Movies { Id = 8, Title = "Forrest Gump", Year = 1994, Genre = "Drama", Rating = 8.8m, Description = "Life as a journey." },
            new Movies { Id = 9, Title = "The Dark Knight", Year = 2008, Genre = "Action", Rating = 9.0m, Description = "Heroism and chaos." },
            new Movies { Id = 10, Title = "Gladiator", Year = 2000, Genre = "Action", Rating = 8.5m, Description = "Honor and revenge." }

        };

        public List<Movies> GetMovies()
        {
            return Movies.ToList();
        }

        public Movies? GetMovieById(int id)
        {
            return Movies.FirstOrDefault(x => x.Id == id);
        }

        public void AppendMovie(Movies movie)
        {
            var nextId = Movies.Any() ? Movies.Max(x => x.Id) + 1 : 1;

        }

    }
}
