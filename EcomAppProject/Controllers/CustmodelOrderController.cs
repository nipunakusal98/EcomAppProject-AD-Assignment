using EcomApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcomAppProject.Controllers
{
    public class CustmodelOrderController : Controller
    {
        private readonly AppDbContext _context;

        public CustmodelOrderController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _context.CustomerConfiguredModelOrders.ToListAsync();
            return View(data);
        }
    }
}
