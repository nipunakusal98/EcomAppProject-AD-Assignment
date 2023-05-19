using EcomApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace EcomAppProject.Controllers
{
    public class SeriesController : Controller
    {
        private readonly AppDbContext _context;

        public SeriesController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Series.ToList();
            return View(data);
        }

    }
}
