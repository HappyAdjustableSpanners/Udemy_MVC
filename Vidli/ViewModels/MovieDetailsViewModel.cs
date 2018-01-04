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
        public string Genre { get; set; }
        public DateTime DateAdded { get; set; }
        public int NumInStock { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}