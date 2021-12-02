using Microsoft.EntityFrameworkCore;
using WebAPICourseService.Models;

namespace WebAPICourseService.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> dbContext)
            :base(dbContext)
        {

        }

        public DbSet<Movie> Movies { get; set; }    
    }
}
