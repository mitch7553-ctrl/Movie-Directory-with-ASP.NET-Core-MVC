using Microsoft.AspNetCore.Mvc;
using Movie_Directory_with_ASP.NET_Core_MVC.Models;
using Movie_Directory_with_ASP.NET_Core_MVC.Service;

namespace Movie_Directory_with_ASP.NET_Core_MVC.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieServices _movieServices;
        public MoviesController(IMovieServices service)
        {
            _movieServices = service;
        }
        public IActionResult Index()
        {
            var movies = _movieServices.GetMovies();
            return View(movies);
        }


        // GET: /Movies/Details/{id}
        public IActionResult Details(int id)
        {
            var movie = _movieServices.GetMovieById(id);
            if (movie == null)
                return NotFound();

            return View(movie); 
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(); // return empty form
        }


        // POST: /Movies/Create
        [HttpPost]
        public IActionResult Create(Movies movie)
        {
            if (!ModelState.IsValid)
                return View(movie);

            _movieServices.AppendMovie(movie);
            return RedirectToAction("Index"); 
        }
    }
}
