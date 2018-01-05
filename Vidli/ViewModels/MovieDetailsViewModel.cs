using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidli.Models;

namespace Vidli.ViewModels
{
    public class MovieDetailsViewModel
    {
        public string Name { get; set; }
        public Genres Genre { get; set; }
        public int GenreId { get; set; }
        public DateTime DateAdded { get; set; }
        public int NumInStock { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}