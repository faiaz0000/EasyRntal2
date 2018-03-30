using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using EasyRental.Models;
using System.ComponentModel.DataAnnotations;

namespace EasyRental.ViewModels
{
    public class MovieFormViewModel
    {
        public int? Id { get; set; }
        [Required]
        [StringLength(255)]
        public String Name { get; set; }

      

        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Date Added")]
        public DateTime? DateAdded { get; set; }

        public int? AvilableInStcock { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public int? GenreId { get; set; }

        

        [Display(Name = "Number In stock")]
        [Required]
        public int? NumberInStock { get; set; }

        [Display(Name = "Currently Available ")]
        [Required]
        public int? NumberAvailable { get; set; }
        public IEnumerable <Genre> GenreList { get; set; }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            GenreId = movie.GenreId;
            NumberInStock = movie.NumberInStock;
            NumberAvailable = movie.NumberAvailable;
            //AvilableInStcock = movie.AvilableInStcock;
            DateAdded = DateTime.Now;
            ReleaseDate = movie.ReleaseDate;

        }

       
    }
}