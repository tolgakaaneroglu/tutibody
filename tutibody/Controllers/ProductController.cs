using Microsoft.AspNetCore.Mvc;
using tutibody.DAL.Context;
using tutibody.DAL.Entities;

namespace tutibody.Controllers
{
    public class ProductController : Controller
    {
        TutibodyContext tutibodyContext = new TutibodyContext();
        public IActionResult ProductList()
        {
            var values = tutibodyContext.Products.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            tutibodyContext.Products.Add(product);
            tutibodyContext.SaveChanges();
            return RedirectToAction("ProductList");
        }
        public IActionResult DeleteProduct(int id)
        {
            var value = tutibodyContext.Products.Find(id);
            tutibodyContext.Products.Remove(value);
            tutibodyContext.SaveChanges();
            return RedirectToAction("ProductList");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var value = tutibodyContext.Products.Find(id);

            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            var value = tutibodyContext.Products.Update(product);
            tutibodyContext.SaveChanges();
            return RedirectToAction("ProductList");
        }
    }
}
