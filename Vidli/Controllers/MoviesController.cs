using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidli.Models;
using Vidli.ViewModels;

namespace Vidli.Controllers
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

        // Pass movies to view
        public ActionResult ShowMovies()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();


            var viewModel = new MoviesViewModel
            {
                Movies = movies
            };

            return View(viewModel);
        }

        public ActionResult ShowMovieDetails(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(c => c.Id == id);
            var viewModel = new MovieDetailsViewModel
            {
                Name = movie.Name,
                Genre = movie.Genre,
                GenreId = movie.GenreId,
                DateAdded = movie.DateAdded,
                ReleaseDate = movie.ReleaseDate,
                NumInStock = movie.NumInStock
            };

            Debug.WriteLine(viewModel);
            return View(viewModel);
        }
        //public ActionResult Edit(int id)
            //{
            //    return Content("id=" + id);
            //}

            ////movies 
            //public ActionResult Index(int? pageIndex, string sortBy)
            //{
            //    // if index not provided default to 1
            //    if (!pageIndex.HasValue)
            //    {
            //        pageIndex = 1;
            //    }

            //    // if sortBy not provided, default to name
            //    if (String.IsNullOrWhiteSpace(sortBy))
            //    {
            //        sortBy = "Name";
            //    }

            //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
            //}

            ////Attribute routing instead of using convention routing in RouteConfig 
            //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
            //public ActionResult ByReleaseDate(int year, int month)
            //{
            //    return Content(String.Format("year={0}, month={1}", year, month));
            //}


        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
            {
                return HttpNotFound();
            }

            // construct view model
            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }

        public ActionResult Create()
        {
            //create movie
            var movie = new Movie();

            // construct view model
            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if(!ModelState.IsValid)
            {
                //return to form
                var viewModel = new MovieFormViewModel
                {
                    Movie = movie,
                    Genres = _context.Genres.ToList()
                };

                return View("MovieForm", viewModel);
            }
            _context.Movies.Add(movie);

            _context.SaveChanges();

            return RedirectToAction("ShowMovies");
        }
    }
}