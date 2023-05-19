using EcomApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace EcomAppProject.Controllers
{
    public class ProcessorController : Controller
    {
        private readonly AppDbContext _context;

        public ProcessorController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Processors.ToList();
            return View(data);
        }
    }
}
