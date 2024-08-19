using Microsoft.AspNetCore.Mvc;
using tutibody.DAL.Context;
using tutibody.DAL.Entities;

namespace tutibody.Controllers
{
    public class ExperienceController : Controller
    {
        TutibodyContext tutibodyContext = new TutibodyContext();
        public IActionResult ExperienceList()
        {
            var values = tutibodyContext.Experiences.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            tutibodyContext.Experiences.Add(experience);
            tutibodyContext.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        public IActionResult DeleteExperience(int id)
        {
            var value = tutibodyContext.Experiences.Find(id);
            tutibodyContext.Experiences.Remove(value);
            tutibodyContext.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
          var value=  tutibodyContext.Experiences.Find(id);

            return View(value);
        }  
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
          var value=  tutibodyContext.Experiences.Update(experience);
            tutibodyContext.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
