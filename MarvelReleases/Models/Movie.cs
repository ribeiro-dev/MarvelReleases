using System;
using System.ComponentModel.DataAnnotations;

namespace MarvelReleases.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }
        public string Img { get; set; }
        public string Genre { get; set; }
    }
}