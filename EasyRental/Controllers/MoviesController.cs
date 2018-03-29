using EasyRental.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyRental.ViewModels;
using System.Data.Entity.Validation;

namespace EasyRental.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool dsiposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            if (User.IsInRole(RoleName.MovieManager))
            {
                return View("List");
            }
            
                return View("ReadOnlyList");
            
        }

        [Authorize(Roles = RoleName.MovieManager)]
        public ActionResult AddNewMovie()
        {
            var genreList = _context.Genres.ToList();
            var ViewModel = new MovieFormViewModel()
            {
               
                GenreList = genreList

            };

            return View(ViewModel);
        }
        [HttpPost]
        [Authorize(Roles = RoleName.MovieManager)]
        public ActionResult Save(Movie movie)
        {

            if (!ModelState.IsValid)
            {
                var genreList = _context.Genres.ToList();
                var ViewModel = new MovieFormViewModel(movie)
                {
                   
                    GenreList = genreList

                };

                return View("AddNewMovie",ViewModel);
            }
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.AvilableInStcock = movie.AvilableInStcock;
                movieInDb.NumberAvailable = movie.NumberAvailable;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.ReleaseDate = movie.ReleaseDate;
            }


            _context.SaveChanges();


            return RedirectToAction("Index", "Movies");
        }
        [Authorize(Roles = RoleName.MovieManager)]
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);


            if (movie == null)
            {
                return HttpNotFound();
            }

            var viewModel = new MovieFormViewModel(movie)
            {
                                    
             GenreList = _context.Genres.ToList()
            };

            return View("AddNewMovie", viewModel);
        }


    }
}