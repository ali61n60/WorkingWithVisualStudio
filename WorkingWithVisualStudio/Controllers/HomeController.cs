using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WorkingWithVisualStudio.Models;

namespace WorkingWithVisualStudio.Controllers
{
    //TODO BrowserLink Didnot Work
    public class HomeController:Controller
    {
        public IRepository Repository = SimpleRepository.SharedRepository;

        public IActionResult Index()
        {
            return View(Repository.Products.Where(p => p?.Price < 50));
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View(new Product());
        }

        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            Repository.AddProduct(p);
            return RedirectToAction("Index");
        }


        
            

       
    }
}
