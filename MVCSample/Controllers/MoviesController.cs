using MVCSample.Models;
using MVCSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSample.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie();
            movie.Name = "Shrek!";
            var movie1 = new Movie();
            movie1.Name = "Wall-e";
            // ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;
            //return View(movie);
            List<Movie> m = new List<Movie>();
            m.Add(movie);
            m.Add(movie1);
            return View(m);
        }

        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}

        //[Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        //public ActionResult ByReleaseDate(int year, byte month)
        //{
        //    return Content(year + "/" + month);
        //}
    }
}