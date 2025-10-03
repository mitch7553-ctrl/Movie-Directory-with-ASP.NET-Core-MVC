using Movie_Directory_with_ASP.NET_Core_MVC.Models;

namespace Movie_Directory_with_ASP.NET_Core_MVC.Service
{
    public interface IMovieServices
    {
        List<Movies> GetMovies();
        Movies? GetMovieById(int id);
        void AppendMovie(Movies movies);
    }
}
