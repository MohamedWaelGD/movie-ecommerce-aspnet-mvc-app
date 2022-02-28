using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieWeb.Data;
using MovieWeb.Models;

namespace MovieWeb.Controllers
{
    public class ProducerController : Controller
    {
        private readonly ApplicationDbContext context;

        public ProducerController(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Producer> data = await context.Producers.ToListAsync();

            return View();
        }
    }
}
