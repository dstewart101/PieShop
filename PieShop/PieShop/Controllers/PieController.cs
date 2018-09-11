using Microsoft.AspNetCore.Mvc;
using PieShop.Interfaces;
using PieShop.ViewModels;

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
            PieListViewModel pieListViewModel = new PieListViewModel();

            pieListViewModel.CurrentCategory = "All the pies we got";
            pieListViewModel.Pies = _pieRepository.GetPies();

            return View(pieListViewModel);
        }
    }
}
