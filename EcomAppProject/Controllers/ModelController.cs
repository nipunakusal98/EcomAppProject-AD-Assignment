using EcomApp.Data;
using EcomAppProject.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var data = await _context.Models.ToListAsync();
            return View(data);
        }
    }
}
