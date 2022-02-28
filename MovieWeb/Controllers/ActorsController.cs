using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieWeb.Data;
using MovieWeb.Data.Services;
using MovieWeb.Models;

namespace MovieWeb.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService service;

        public ActorsController(IActorsService _service)
        {
            service = _service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await service.GetAll();
            return View(data);
        }
    }
}
