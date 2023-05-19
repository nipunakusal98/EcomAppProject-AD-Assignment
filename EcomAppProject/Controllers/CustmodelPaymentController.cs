using EcomApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcomAppProject.Controllers
{
    public class CustmodelPaymentController : Controller
    {
        private readonly AppDbContext _context;

        public CustmodelPaymentController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _context.CustomerConfiguredModelPayments.ToListAsync();
            return View(data);
        }
    }
}
