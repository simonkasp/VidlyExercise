using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MovieFormViewModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }
        [Display(Name = "Number in Stock")]
        [Between0And20NumberInStock]
        [Range(1, 20)]
        public int? NumberInStock { get; set; }
        [Display(Name = "Genre")]
        public int? GenreId { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}