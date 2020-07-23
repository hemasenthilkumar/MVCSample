using MVCSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSample.ViewModels
{
    public class NewMovieAdd
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}