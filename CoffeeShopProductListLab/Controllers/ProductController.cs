using CoffeeShopProductListLab.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace CoffeeShopProductListLab.Controllers
{
    public class ProductController : Controller
    {
        CoffeeProductsDbContext dbContext = new CoffeeProductsDbContext();
        [HttpGet]
        public IActionResult Index(string name)
        {
            List<Product> result = dbContext.Products.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            Product result = dbContext.Products.FirstOrDefault(x => x.Id == id);
            return View(result);
        }
        [HttpGet]
        public IActionResult CatagoryFood(int id)
        {
            Product result = (Product)dbContext.Products.DistinctBy(y => y.Category == "Food");
            return View(result);
        }

        [HttpGet]
        public IActionResult CatagoryDrink(int id)
        {
            Product result = (Product)dbContext.Products.DistinctBy(x => x.Category == "Drinks");
            return View(result);
        }
    }
}


