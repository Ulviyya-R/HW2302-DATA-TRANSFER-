using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.ViewModels;

namespace WebApplication3.Controllers
{
    public class HomeController:Controller
    {
        public List<Product> Products;
        public List<Category> Categories;

        public IActionResult Index() 
        {
			BazaVM model = new BazaVM();

			return View(model);
		}
		public ActionResult Detail()
		{
			return View();
		}
	}
}
