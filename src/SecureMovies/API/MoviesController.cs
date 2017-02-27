using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SecureMovies.Models;
using SecureMovies.Data;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SecureMovies.API
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        public ApplicationDbContext _db;

        public MoviesController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: api/values
        [HttpGet]
        [Authorize]
        public List<Movie> Get()
        {
            return _db.Movies.ToList();
        }

    }
}
