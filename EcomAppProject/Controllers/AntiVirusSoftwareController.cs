using EcomApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace EcomAppProject.Controllers
{
    public class AntiVirusSoftwareController : Controller
    {
        private readonly AppDbContext _context;

        public AntiVirusSoftwareController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.AntivirusSoftwares.ToList();
            return View(data);
        }
    }
}
