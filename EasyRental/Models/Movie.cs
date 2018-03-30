﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyRental.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public String Name { get; set; }


        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

       

        [Display(Name = "Genre")]
        [Required]
        public int? GenreId { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Number In stock")]
        public int NumberInStock { get; set; }

        [Display(Name = "Currently Available ")]
        public int NumberAvailable { get; set; }
    }
}