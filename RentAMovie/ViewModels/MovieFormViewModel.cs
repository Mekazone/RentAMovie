using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RentAMovie.Models;

namespace RentAMovie.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

        //set title of the form as new movie or edit movie
        public string Title
        {
            get { return Movie.Id == 0 ? "New Movie" : "Edit Movie"; }
        }
    }
}