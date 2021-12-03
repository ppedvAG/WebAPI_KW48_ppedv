using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICourseService.Data;
using WebAPICourseService.Models;

namespace WebAPICourseService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReturnValuesController : ControllerBase
    {

        //https://docs.microsoft.com/de-de/aspnet/core/web-api/action-return-types?view=aspnetcore-6.0


        //Native Datentypen

        //IActionResult / ActionResult / ActionResult<T> 

        //IEnumerable + IAsynEnumerable  //serial eine Liste übergeben

        private readonly MovieDbContext _ctx;

        public ReturnValuesController(MovieDbContext ctx)
        {
            _ctx = ctx;
        }

        #region Native Typen + IEnumberable + IAsyncEnumerable
        [HttpGet("nativeDatatypes")]
        public List<Movie> GetMovies () 
        {
            return _ctx.Movies.ToList();
        }



        //Wenn eine Aktion in ASP.NET Core 2.2 und früher IEnumerable<T> zurückgibt, führt dies zu einer synchronen Sammlungsiteration durch das Serialisierungsprogramm.
        ////Das Ergebnis sind die Blockierung von Aufrufen und die potenzielle Außerkraftsetzung des Threadpools. 
        //Serialisierung

        //Um synchrone Enumeration und blockierendes Warten auf die Datenbank in ASP.NET Core 2.2 und früher zu vermeiden, rufen Sie ToListAsync auf:
        [HttpGet("SerialisierungWithIEnumberable")]
        public IEnumerable<Movie> GetComedyMovies()
        {
            var allMovies = _ctx.Movies.ToList();

            foreach (Movie currentMovie in allMovies)
            {
                yield return currentMovie; //
            }
        }

        //Ab ASP.NET Core 3.0 stabil
        [HttpGet("asyncsale")]
        public async IAsyncEnumerable<Movie> GetOnSaleProductsAsync()
        {
            var allMovies = await _ctx.Movies.ToListAsync();

            foreach (var currentMovie in allMovies)
            {
                yield return currentMovie;
            }
        }
        #endregion




    }
}
