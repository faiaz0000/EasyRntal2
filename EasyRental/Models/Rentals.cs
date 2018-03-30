using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EasyRental.Models
{
    public class Rentals
    {
        public int Id { get; set; }
        [Required]
        public Movie Movie { get; set; }
        [Required]
        public Customer Customer { get; set; }

        public DateTime DateRented { get; set; }

        public DateTime? ReturnDate { get; set; }
    }
}