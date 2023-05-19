using EcomApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace EcomAppProject.Controllers
{
    public class VGAController : Controller
    {
        private readonly AppDbContext _context;

        public VGAController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.VGAs.ToList();
            return View();
        }
    }
}
