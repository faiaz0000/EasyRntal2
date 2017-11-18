using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyRental.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public String Name { get; set; }


      
        public DateTime ReleaseDate { get; set; }

      
        public DateTime DateAdded { get; set; }

        public int AvilableInStcock { get; set; }

       
        [Required]
        public int? GenreId { get; set; }

   

        
        public int NumberInStock { get; set; }

       
        public int NumberAvailable { get; set; }
    }
}