using Microsoft.AspNetCore.Mvc;
using PieShop.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PieShop.Controllers
{
    public class PieController : Controller
    {

        private IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository) {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;

        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = "List of Pies";

            var pies = _pieRepository.GetPies();

            return View(pies);
        }
    }
}
