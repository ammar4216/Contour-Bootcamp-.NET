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
            await _context.Movie.ToListAsync();
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<Movie>> PostMovie(Movie movie)
        {
            if(movie == null)
            {
                return BadRequest();
            }
            else
            {
                _context.Movie.Add(movie);
                await _context.SaveChangesAsync();
            }

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> PutMovie(int id, Movie movie)
        {
            if(id != movie.Id)
            {
                return BadRequest();
            }
        }
        
    }
}
