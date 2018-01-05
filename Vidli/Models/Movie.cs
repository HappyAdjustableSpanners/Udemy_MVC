using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidli.Models
{
    public class Movie
    {
       
        public int Id { get; set; }

        [Required][StringLength(255)] public string Name { get; set; }

        public Genres Genre { get; set; }
 
        [Required]
        public int GenreId { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        public int NumInStock { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }
    }
}