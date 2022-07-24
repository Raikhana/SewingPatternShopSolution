using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SewingPatternShop.Models;

namespace SewingPatternShop.Controllers
{
    public class ProductController : Controller
    {
        private ShopContextSew context;

        public ProductController(ShopContextSew ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return RedirectToAction("List", "Product");
        }

        [Route("[controller]s/{id?}")]
        public IActionResult List(string id = "All")
        {
            var categories = context.Categories
                .OrderBy(c => c.CategoryID).ToList();

            List<Product> products;
            if (id == "All")
            {
                products = context.Products
                    .OrderBy(p => p.ProductID).ToList();
            }
            else if (id == "Dress")
            {
                products = context.Products
                    .Where(p => p.Category.Name == "Dress")
                    .OrderBy(p => p.ProductID).ToList();
            }
            else
            {
                products = context.Products
                    .Where(p => p.Category.Name == id)
                    .OrderBy(p => p.ProductID).ToList();
            }
            ViewBag.Categories = categories;
            ViewBag.SelectedCategoryName = id;
            if (id == "Dress")
            {
                ViewBag.SelectedCategoryName = "Dress";
            }
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var categories = context.Categories
                .OrderBy(c => c.CategoryID).ToList();

            Product product = context.Products.Find(id);

            string imageFilename = product.Code + ".png";

            ViewBag.Categories = categories;
            ViewBag.ImageFilename = imageFilename;
            return View(product);
        }
    }
}
