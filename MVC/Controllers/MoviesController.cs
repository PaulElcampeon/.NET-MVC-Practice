using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;
using MVC.ViewModels;


namespace MVC.Controllers
{
    public class MoviesController : Controller
    {

        [Route("movies")]
        [Route("movies/index")]
        [Route("movies/home")]
        public ActionResult Index()
        {
            MovieViewModel viewModel = new MovieViewModel()
            {
                Movies = GetMovies()
            };

            return View("~/Views/Movies/Index.cshtml", viewModel);
        }

        public List<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie(){ Id = 1, Name = "Shrek!" },
                new Movie(){Id = 2, Name = "Dalmations" }
            };

            return movies;
        }
    }
}