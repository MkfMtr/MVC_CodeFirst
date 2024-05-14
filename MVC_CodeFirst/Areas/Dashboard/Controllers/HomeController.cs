using Microsoft.AspNetCore.Mvc;
using MVC_CodeFirst.Areas.Dashboard.Repositories.Abstracts;
using MVC_CodeFirst.Models.Entities;

namespace MVC_CodeFirst.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class HomeController : Controller
    {
        private readonly IMovieService _movieService;

        public HomeController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public IActionResult Index()
        {
            List<Movie> movies = _movieService.ListMovies();

            #region makif-Test
            //List<Movie> movies = new List<Movie>()
            //{
            //    new Movie { ID = 1, Title = "Film 1", Description = "Açıklama 1", DirectorId = 1 },
            //    new Movie { ID = 2, Title = "Film 2", Description = "Lorem ipsum", DirectorId = 2 },
            //}; 
            #endregion

            return View(movies);
        }
    }
}
