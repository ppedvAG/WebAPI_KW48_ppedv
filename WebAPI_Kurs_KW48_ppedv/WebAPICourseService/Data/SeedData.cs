using System.Linq;
using WebAPICourseService.Models;

namespace WebAPICourseService.Data
{
    public static class SeedData
    {
        public static void Init(MovieDbContext context)
        {
            if (!context.Movies.Any())
            {
                context.Movies.AddRange(
                   new Movie { Title = "Juraasic Park", Description = "TRex wird Veggie", Price = 10, Genre = GenreTyp.Action },
                    new Movie { Title = "Juraasic Park 2", Description = "TRex hört auf Veggie zu sein", Price = 11, Genre = GenreTyp.Action },
                    new Movie { Title = "Juraasic Park 3", Description = "Neuer PArk wird gegründet", Price = 12, Genre = GenreTyp.Action },
                    new Movie { Title = "Juraasic Park 4", Description = "TRex wird Veggie", Price = 10, Genre = GenreTyp.Action },
                    new Movie { Title = "Juraasic Park 5", Description = "TRex hört auf Veggie zu sein", Price = 11, Genre = GenreTyp.Action },
                    new Movie { Title = "Juraasic Park 6", Description = "Neuer PArk wird gegründet", Price = 12, Genre = GenreTyp.Action },
                    new Movie { Title = "Juraasic Park 7", Description = "TRex wird Veggie", Price = 10, Genre = GenreTyp.Action },
                    new Movie { Title = "Juraasic Park 8", Description = "TRex hört auf Veggie zu sein", Price = 11, Genre = GenreTyp.Action },
                    new Movie { Title = "Juraasic Park 9", Description = "Neuer PArk wird gegründet", Price = 12, Genre = GenreTyp.Action }

                    );

                context.SaveChanges();
            }
        }
    }
}
