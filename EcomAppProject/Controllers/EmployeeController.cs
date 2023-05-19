using EcomApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace EcomAppProject.Controllers
{
    public class EmployeeController : Controller
    {
         private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Employees.ToList();
            return View(data);
        }
    }
}
