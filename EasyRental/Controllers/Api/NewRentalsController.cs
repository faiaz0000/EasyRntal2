using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using EasyRental.Dtos;
using EasyRental.Models;

namespace EasyRental.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public  NewRentalsController()
            {

            _context = new ApplicationDbContext();

            }


        [System.Web.Http.HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            //throw new NotImplementedException();
            var customer = _context.Customers.Single(
                c => c.Id == newRental.CustomerId);
            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id));
            foreach(var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie not available");
                movie.NumberAvailable--;
                var rental = new Rentals
                {
                    Customer = customer,
                    Movie= movie,
                    DateRented=DateTime.Now

                };
                _context.Rentals.Add(rental);
            }
            _context.SaveChanges();

            return Ok();
        }
    }
}