using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
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
        [Route("Customers")]
        public ActionResult Random()
        {
            //var movie = new Movie() { Name = "Shrek!" };

            /*var customers = new List<Customer>
            {
                new Customer {Name = "John Smith", id = 1},
                new Customer {Name = "Marry Williams", id = 2}
            };*/

            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            var viewModel = new RandomMovieViewModel
            {
                Customers = customers
            };

            System.Diagnostics.Debug.WriteLine(customers);

            return View(viewModel);

            // return Content("Hello World");
            // return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            var customers = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.id == id);

            return View(customers);

        }


        [Route("Movies")]
        public ActionResult ShowMovies()
        {
            var movies = _context.Movie.Include(m => m.Genre).ToList();

            var viewModel = new MovieViewModel
            {
                Movie = movies
            };

            return View(viewModel);

        }

        [Route("Movies/Details/{id}")]
        public ActionResult MoviesDetails(int id)
        {
            var movies = _context.Movie.SingleOrDefault(m => m.Id == id);

            return View(movies);

        }

        /*public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }*/

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]

        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult New()
        {
            var genres = _context.Genre.ToList();
            var viewModel = new MovieFormViewModel
            {
                Genre = genres
            };

            return View("MovieForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            _context.Movie.Add(movie);
            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }
    }
}