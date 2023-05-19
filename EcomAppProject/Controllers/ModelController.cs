using EcomApp.Data;
using EcomAppProject.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcomAppProject.Controllers
{
    public class ModelController : Controller
    {
        private readonly AppDbContext _context;

        public ModelController(AppDbContext service)
        {
            _context = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = _context.Models.ToList();
            return View(data);
        }
    }
}
