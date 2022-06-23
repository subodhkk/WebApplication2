using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using System.Collections.Generic;
namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    {
        
        public IActionResult GetAllProducts()
        {
            List<Product> productlist = new List<Product>
            {
                new Product { Id = 1, Name ="Laptop",Company="Dell",Price=35000},
                new Product { Id = 2, Name ="Laptop",Company="HP",Price=37000},
                new Product { Id = 3, Name ="Keybord",Company="Dell",Price=500},
                new Product { Id = 4, Name ="Mouse",Company="Dell",Price=400}

            };
            ViewBag.ProductList = productlist;
            return View();
           
        }

        public IActionResult AddNew()
        {
            return View();
        }

    }
}
