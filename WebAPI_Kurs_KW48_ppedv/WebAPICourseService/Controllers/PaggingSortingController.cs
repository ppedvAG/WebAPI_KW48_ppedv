using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICourseService.Data;
using WebAPICourseService.Models;

namespace WebAPICourseService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaggingSortingController : ControllerBase
    {
        private readonly MovieDbContext _dbContext;
        public PaggingSortingController(MovieDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        //.Skip((pageNumber - 1) * pageSize).Take(pageSize)

        [HttpGet("EasyPageingList")]
        public async Task<ActionResult<IEnumerable<Movie>>> EasyPagingList(int pageNumber, int pageSize)
        {
            return await _dbContext.Movies.OrderBy(o => o.Title)
                                          .Skip((pageNumber - 1) * pageSize)
                                          .Take(pageSize).ToListAsync();
        }

        [HttpGet("PagingListWithPageParametersObject")]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies([FromQuery] PageParameters parameters)
        {
            return await _dbContext.Movies.OrderBy(o => o.Title)
                .Skip((parameters.PageNumber - 1) * parameters.PageSize)
                .Take(parameters.PageSize)
                .ToListAsync();
        }

    }

    public class PageParameters
    {
        const int maxPageSize = 3;

        public int PageNumber { get; set; } = 1;
        private int _pageSize = 3;

        public int PageSize
        {
            get
            {
                return _pageSize;
            }

            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }
    }
}
