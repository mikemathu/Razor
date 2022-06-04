using Microsoft.AspNetCore.Mvc;
using Razor.Models;
using System.Diagnostics;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index()
        {
            /*Product myProduct = new Product
            {
                //Populating of Product object
                 ProductID = 1,
                  Name = "Kayak",
                  Description = "A boat for one person",
                  Category = "Watersports",
                  Price = 275M
              };

              ViewBag.StockLevel = 2;

              return View(myProduct); //passed product to the view*/


            /*Enumerating Array and Collection*/
            //This action method creates a Product[] object that contains simple data values and passes them to the view method so that the data is rendered using the default view
            Product[] array =
            {
                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "Lifejacket", Price = 48.95M },
                new Product { Name = "Soccer ball", Price = 19.5M },
                new Product { Name = "Corner flag", Price = 34.95M }
            };          

              return View(array);
                                      







        }




    }
}