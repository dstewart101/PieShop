using Microsoft.AspNetCore.Mvc;
using PieShop.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PieShop.Controllers
{
    public class HomeController : Controller
    {

        private IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository) {
            _pieRepository = pieRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_pieRepository.GetPies());
        }
    }
}
