using Microsoft.AspNetCore.Mvc;
using tutibody.DAL.Context;
using tutibody.DAL.Entities;

namespace tutibody.Controllers
{
    public class SponsorController : Controller
    {
        TutibodyContext tutibodyContext = new TutibodyContext();
        public IActionResult SponsorList()
        {
            var values = tutibodyContext.Sponsors.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateSponsor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSponsor(Sponsor sponsor)
        {
            tutibodyContext.Sponsors.Add(sponsor);
            tutibodyContext.SaveChanges();
            return RedirectToAction("SponsorList");
        }
        public IActionResult DeleteSponsor(int id)
        {
            var value = tutibodyContext.Sponsors.Find(id);
            tutibodyContext.Sponsors.Remove(value);
            tutibodyContext.SaveChanges();
            return RedirectToAction("SponsorList");
        }
        [HttpGet]
        public IActionResult UpdateSponsor(int id)
        {
          var value=  tutibodyContext.Sponsors.Find(id);

            return View(value);
        }  
        [HttpPost]
        public IActionResult UpdateSponsor(Sponsor sponsor)
        {
          var value=  tutibodyContext.Sponsors.Update(sponsor);
            tutibodyContext.SaveChanges();
            return RedirectToAction("SponsorList");
        }
    }
}
