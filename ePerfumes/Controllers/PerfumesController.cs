using ePerfumes.Data;
using ePerfumes.Data.Services;
using ePerfumes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ePerfumes.Controllers
{
    public class PerfumesController : Controller
    {
        private readonly IPerfumeService _service;

        public PerfumesController(IPerfumeService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            
            var AllPerfumes = await _service.GetAllAsync();
            return View(AllPerfumes);
        }
        

        public async Task<IActionResult> IndexUser()
        {
            var AllPerfumes = await _service.GetAllAsync();
            return View(AllPerfumes);
        }

        //Get: Perfume/Create
        public async Task<IActionResult> Create()
        {
            var Marcas = await _service.GetAllAsync();
            ViewBag.Marcas = new SelectList(Marcas, "Marca_ID", "Marca_Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Perfume_Name,Perfume_Pic_URL,Tamanho,Price,PerfumeType,PerfumeVersion")]Perfume perfume)
        {
            if (!ModelState.IsValid)
            {
                return View(perfume);
            }
            await _service.AddAsync(perfume);
            return RedirectToAction(nameof(Index));
        }

        //Get: Marcas/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var PerfumeDetails = await _service.GetByIDAsync(id);
            if (PerfumeDetails == null) return View("Not Found");
            return View(PerfumeDetails);
        }

        //Get: Perfume/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var PerfumeDetails = await _service.GetByIDAsync(id);
            if (PerfumeDetails == null) return View("Not Found");
            return View(PerfumeDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Perfume_ID,Perfume_Name,Perfume_Pic_URL,Tamanho,Price,PerfumeType,PerfumeVersion")] Perfume perfume)
        {
            if (!ModelState.IsValid)
            {
                return View(perfume);
            }
            await _service.UpdateAsync(id, perfume);
            return RedirectToAction(nameof(Index));
        }

    }
}
