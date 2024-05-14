using Microsoft.EntityFrameworkCore;
using MVC_CodeFirst.Areas.Dashboard.Repositories.Abstracts;
using MVC_CodeFirst.Models.Context;
using MVC_CodeFirst.Models.Entities;
namespace MVC_CodeFirst.Areas.Dashboard.Repositories.Services
{
    public class MovieService : IMovieService
    {
        private MovieProjectContext _projectContext = new MovieProjectContext();
        //public MovieService(MovieProjectContext movieProjectContext)
        //{
        //    _projectContext = movieProjectContext;
        //}

        public void CreateMovie(Movie movie)
        {
            try
            {
                _projectContext.Movies.Add(movie);
                _projectContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
