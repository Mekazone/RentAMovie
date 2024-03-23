using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RentAMovie.Models;
using RentAMovie.Dtos;

namespace RentAMovie.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;
        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {            
            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);
            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id)).ToList();

            foreach(var movie in movies)
            {
                if (movie.NumberInStock == 0)
                    return BadRequest("Movie is not available");

                movie.NumberInStock--;
                var rental = new Rental
                {
                    Customer = customer,
                    DateRented = DateTime.Now,
                    Movie = movie
                };
                _context.Rentals.Add(rental);
            }
            _context.SaveChanges();
            return Ok();
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}