using ePerfumes.Data;
using ePerfumes.Data.Services;
using ePerfumes.Models;
using Microsoft.AspNetCore.Mvc;

namespace ePerfumes.Controllers
{
    public class MarcasController : Controller
    {
        private readonly IMarcasService _service;

        public MarcasController(IMarcasService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var data = _service.GetAll();
            return View(data);
        }
        //Get: Marca/Create
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Marca_Name, Marca_Pic_URL")]Marca marca) 
        {
            if(!ModelState.IsValid)
            {
                return View(marca);
            }
            _service.Add(marca);
            return RedirectToAction(nameof(Index));
        }
    }
}
