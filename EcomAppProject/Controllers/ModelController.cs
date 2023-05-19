using EcomApp.Data;
using EcomAppProject.Data.Services;
using EcomAppProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var data = await _service.GetAll();
            return View(data);
        }

        [HttpPost]

        public async Task <IActionResult> Create(Model model)
        {
            if 
            {

            }

        }
    }
}
