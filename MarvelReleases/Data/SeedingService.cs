using System;
using System.Linq;
using MarvelReleases.Models;

namespace MarvelReleases.Data
{
    public class SeedingService
    {
        private readonly AppDbContext _context;

        public SeedingService(AppDbContext context)
        {
            _context = context;
        }

        public void Init()
        {
            SeedMovies();
            _context.SaveChanges(); // save the database
        }

        private void SeedMovies()
        {
            // Create the movies and add in the DB

            // DB already seeded
            if (_context.Movies.Any()) return;

            // Movies
            Movie m1 = new Movie {
                Id = 1,
                MovieName = "Eternos",
                ReleaseDate = new DateTime(2021, 11, 5),
                Img = "./Img/Eternos.png",
                Genre = "Série"
            };

            Movie m2 = new Movie {
                Id = 2,
                MovieName = "Gavião Arqueiro",
                ReleaseDate = new DateTime(2021, 11, 24),
                Img = "./Img/Hawkeye.png",
                Genre = "Série"
            };

            Movie m3 = new Movie {
                Id = 3,
                MovieName = "Homem-Aranha 3: Sem Volta Para Casa",
                ReleaseDate = new DateTime(2021, 12, 16),
                Img = "./Img/Homem-Aranha.jpg",
                Genre = "Filme"
            };

            Movie m4 = new Movie {
                Id = 4,
                MovieName = "Thor: Love and Thunder",
                ReleaseDate = new DateTime(2022, 5, 6),
                Img = "./Img/Thor.png",
                Genre = "Filme"
            };
            
            Movie m5 = new Movie {
                Id = 5,
                MovieName = "Deadpool 3",
                ReleaseDate = null,
                Img = "./Img/Deadpool-3.jpg",
                Genre = "Filme"
            };
            
            Movie m6 = new Movie {
                Id = 6,
                MovieName = "Mulher Hulk",
                ReleaseDate = null,
                Img = "./Img/Mulher-Hulk.jpg",
                Genre = "Série"
            };

            _context.Movies.AddRange(m1, m2, m3, m4, m5, m6);
        }
    }
}