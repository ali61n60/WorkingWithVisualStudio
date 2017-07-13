using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkingWithVisualStudio.Models;
using System.Linq;

namespace WorkingWithVisualStudio.Controllers
{
    //TODO BrowserLink Didnot Work
    public class HomeController:Controller
    {
        public IActionResult Index()
        {

            return View(SimpleRepository.SharedRepository.Products.
                Where(p => p?.Price < 50));
        }
            

       
    }
}
