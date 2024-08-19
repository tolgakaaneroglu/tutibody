using Microsoft.AspNetCore.Mvc;
using tutibody.DAL.Context;
using tutibody.DAL.Entities;

namespace tutibody.Controllers
{
    public class AboutController : Controller
    {
        TutibodyContext tutibodyContext = new TutibodyContext();
        public IActionResult AboutList()
        {
            var values = tutibodyContext.Abouts.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var value = tutibodyContext.Abouts.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            var value = tutibodyContext.Abouts.Update(about);
            tutibodyContext.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}
