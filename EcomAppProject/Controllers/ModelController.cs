using EcomApp.Data;
using EcomAppProject.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcomAppProject.Controllers
{
    public class ModelController : Controller
    {
        private readonly IModelService _service;

        public ModelController(IModelService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = _service.GetAll();
            return View(data);
        }
    }
}
