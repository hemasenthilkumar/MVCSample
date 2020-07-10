using MVCSample.Models;
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
            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
    }
}