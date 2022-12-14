using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIWithASPMVC.Data;
using APIWithASPMVC.Models;

namespace APIWithASPMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly APIWithASPMVCContext _context;

        public MoviesController(APIWithASPMVCContext context)
        {
            _context = context;
        }

        //api/Movie : GET all Movies from Database
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
        {
            return await _context.Movie.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Movie>> InsertMovie(Movie movie)
        {
            if(movie == null)
            {
                return BadRequest();
            }
            else
            {
                _context.Movie.Add(movie);
            }

            await _context.SaveChanges();
        }
        
    }
}
