using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieWeb.Data;
using MovieWeb.Models;

namespace MovieWeb.Controllers
{
    public class CinemaController : Controller
    {
        private readonly ApplicationDbContext context;

        public CinemaController(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Cinema> data = await context.Cinemas.ToListAsync();
            return View(data);
        }
    }
}
