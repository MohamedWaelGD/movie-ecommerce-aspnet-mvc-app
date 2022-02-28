using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieWeb.Data;
using MovieWeb.Models;

namespace MovieWeb.Controllers
{
    public class ActorsController : Controller
    {
        private readonly ApplicationDbContext context;

        public ActorsController(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Actor> data = await context.Actors.ToListAsync();
            return View();
        }
    }
}
