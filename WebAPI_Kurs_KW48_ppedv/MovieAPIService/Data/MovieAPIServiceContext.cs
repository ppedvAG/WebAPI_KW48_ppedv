using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieAPIService.Models;

namespace MovieAPIService.Data
{
    public class MovieAPIServiceContext : DbContext
    {
        public MovieAPIServiceContext (DbContextOptions<MovieAPIServiceContext> options)
            : base(options)
        {
        }

        public DbSet<MovieAPIService.Models.Movie> Movie { get; set; }
    }
}
