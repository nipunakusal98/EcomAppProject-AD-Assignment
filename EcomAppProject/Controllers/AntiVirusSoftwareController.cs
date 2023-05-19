using EcomApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcomAppProject.Controllers
{
    public class AntiVirusSoftwareController : Controller
    {
        private readonly AppDbContext _context;

        public AntiVirusSoftwareController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _context.AntivirusSoftwares.ToListAsync();
            return View(data);
        }
    }
}
