using EcomApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace EcomAppProject.Controllers
{
    public class ModelController : Controller
    {
        private readonly AppDbContext _context;

        public ModelController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Models.ToList();
            return View(data);
        }
    }
}
