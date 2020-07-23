using MVCSample.Models;
using MVCSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace MVCSample.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movies

        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }

        public ActionResult Random(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return HttpNotFound();
            return View(movie);
               
        }

        public ActionResult New()
        {
            var genres = _context.Genres.ToList();
            var viewModel = new NewMovieAdd()
            {
                Genres = genres
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(c => c.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.Genre = movie.Genre;
                movieInDb.NumberinStock = movie.NumberinStock;
            }
            try { _context.SaveChanges(); }
            catch(DbEntityValidationException e)
            {
                Console.WriteLine(e);
            }
            
            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if(movie==null)
            {
                return HttpNotFound();
            }
            var viewModel = new NewMovieAdd()
            {
                Movie = movie,
                Genres = _context.Genres.ToList()
                
            };
            return View("New", viewModel);
        }
    }
}