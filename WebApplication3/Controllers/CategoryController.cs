using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.ViewModels;

namespace WebApplication3.Controllers
{
	public class CategoryController:Controller
	{
		public List<Category> Categories;

		public IActionResult Index()
		{
			BazaVM model = new BazaVM();
			
			return View(model) ;
		}
	}
}
