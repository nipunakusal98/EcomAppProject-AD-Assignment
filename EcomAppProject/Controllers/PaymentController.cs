using Microsoft.AspNetCore.Mvc;

namespace EcomAppProject.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
