using Microsoft.AspNetCore.Mvc;
using Raxor.Models;

namespace Raxor.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Product product = new Product
            {
                ProductID = 1,
                Name = "Kayak",
                Descriptin = "A boat for one person",
                Categore = "Watersports",
                Price = 275M
            };
            return View(product);
        }
    }
}