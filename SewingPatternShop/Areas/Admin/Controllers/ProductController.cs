using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SewingPatternShop.Models;

namespace SewingPatternShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private ShopContextSew context;
        private List<Category> categories;

        public ProductController(ShopContextSew ctx)
        {
            context = ctx;
            categories = context.Categories
                    .OrderBy(c => c.CategoryID)
                    .ToList();
        }

        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        [Route("[area]/[controller]s/{id?}")]
        public IActionResult List(string id = "All")
        {
            List<Product> products;
            if (id == "All")
            {
                products = context.Products
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
            return View(products);
        }

        [HttpGet]
        public IActionResult Add()
        {
            Product product = new Product();               
            product.Category = context.Categories.Find(1); 

            ViewBag.Action = "Add";
            ViewBag.Categories = categories;
            return View("AddUpdate", product);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Product product = context.Products
                .Include(p => p.Category)
                .FirstOrDefault(p => p.ProductID == id);

            ViewBag.Action = "Update";
            ViewBag.Categories = categories;
            return View("AddUpdate", product);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.ProductID == 0)           
                {
                    context.Products.Add(product);
                }
                else                                  
                {
                    context.Products.Update(product);
                }
                context.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                ViewBag.Action = "Save";
                ViewBag.Categories = categories;
                return View("AddUpdate", product);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Product product = context.Products
                .FirstOrDefault(p => p.ProductID == id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            context.Products.Remove(product);
            context.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
