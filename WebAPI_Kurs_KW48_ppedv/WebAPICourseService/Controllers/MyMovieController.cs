using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPICourseService.Data;
using WebAPICourseService.Models;
using System.Linq;

namespace WebAPICourseService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class MyMovieController : ControllerBase
    {
        private readonly MovieDbContext _context;

        public MyMovieController(MovieDbContext context)
        {
            _context = context;
        }

        [HttpGet("/MovieWithLowestPrice")]
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
        public ActionResult<Movie> GetLowestPriceMovie()
        {
            return _context.Movies.OrderBy(o => o.Price).FirstOrDefault();
        }

        [HttpGet("/MovieWithHighestPrice")]
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
        public ActionResult<Movie> GetHighestPriceMovie()
        {
            return _context.Movies.OrderByDescending(o => o.Price).FirstOrDefault();
        }

        [HttpGet("{id}")]
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
        public ActionResult<Movie> GetById(int id)
        {
            return _context.Movies.Find(id);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public ActionResult InsertMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();

            return CreatedAtAction("GetById", new { id = movie.Id }, movie);
        }

        [HttpPost("/AlternativesInsert")]
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Post))]
        public ActionResult InsertMovie2(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();

            return CreatedAtAction("GetById", new { id = movie.Id }, movie);
        }

        [HttpPut("{id}")]
        public IActionResult Update (int id, Movie movie)
        {
            if (id != movie.Id)
                return BadRequest();

            _context.Movies.Update(movie);
            _context.SaveChanges();

            return Ok();
        }
    }
}
