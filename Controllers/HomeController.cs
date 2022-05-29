using Microsoft.AspNetCore.Mvc;
using Razor.Models;
using System.Diagnostics;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index()
        {
            Product myProduct = new Product
            {
                //Populating of Product object
                ProductID = 1,
                Name = "Kayak",
                Description = "A boat for one person",
                Category = "Watersports",
                Price = 275M
            };

            ViewBag.StockLevel = 2;

            return View(myProduct); //passed product to the view
        }

    }
}