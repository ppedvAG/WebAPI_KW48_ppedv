using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPIService.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public GenreTyp Genre { get; set; }
        public decimal Price { get; set; }

    }

    public enum GenreTyp { Action = 0, Thriller, Darama, Comedy, Horror, Documentary }
}
