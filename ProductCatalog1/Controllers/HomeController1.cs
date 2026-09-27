using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Description = "HP Laptop",
                    Price = 55000,
                    Category = "Electronics"
                },

                new Product
                {
                    Id = 2,
                    Name = "Mobile",
                    Description = "Android Smartphone",
                    Price = 25000,
                    Category = "Electronics"
                },

                new Product
                {
                    Id = 3,
                    Name = "Headphones",
                    Description = "Wireless Headphones",
                    Price = 3000,
                    Category = "Accessories"
                }
            };

            return View(products);
        }
    }
}