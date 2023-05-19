using EcomApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace EcomAppProject.Controllers
{
    public class CustomerconfirgurationController : Controller
    {
        private readonly AppDbContext _context;

        public CustomerconfirgurationController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.CustomerConfigurations.ToList();
            return View(data);
        }
    }
}
