using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.ViewModels;

namespace WebApplication3.Controllers
{
	public class ProductsController : Controller
	{
		public List<Product> Products;


		public IActionResult Index()
		{
			BazaVM model = new BazaVM();

			return View(model);
		}
	}
}
