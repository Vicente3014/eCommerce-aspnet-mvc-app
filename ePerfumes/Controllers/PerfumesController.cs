using ePerfumes.Data;
using Microsoft.AspNetCore.Mvc;

namespace ePerfumes.Controllers
{
    public class PerfumesController : Controller
    {
        private readonly AppDBContext _dbContext;

        public PerfumesController(AppDBContext context)
        {
            _dbContext = context;
        }
        public IActionResult Index()
        {
            var AllPerfumes = _dbContext.Perfumes.ToList();
            return View(AllPerfumes);
        }

        public IActionResult IndexUser()
        {
            var AllPerfumes = _dbContext.Perfumes.ToList();
            return View(AllPerfumes);
        }
    }
}
