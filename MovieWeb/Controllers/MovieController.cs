using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieWeb.Data;
using MovieWeb.Models;

namespace MovieWeb.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext context;

        public MovieController(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Movie> data = await context.Movies.ToListAsync();

            return View();
        }
    }
}
