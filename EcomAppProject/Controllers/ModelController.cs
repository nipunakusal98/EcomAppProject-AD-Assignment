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


        //Get: Models/Create
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        public async Task<IActionResult> Create()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("ModelName,ModelPictureURL,DefaultRAM" +
            "DefaultVGA, DefaultProcessor,DefaultOS,DefaultAntivirus,DefaultModelPrice")] Model model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            _service.Add(model);
            return RedirectToAction(nameof(Index));

        }
    }
}
