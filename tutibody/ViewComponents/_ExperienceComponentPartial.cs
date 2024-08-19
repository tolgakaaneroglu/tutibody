using Microsoft.AspNetCore.Mvc;
using tutibody.DAL.Context;

namespace tutibody.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        TutibodyContext tutibodyContext = new TutibodyContext();
        public IViewComponentResult Invoke()
        {
            var values = tutibodyContext.Experiences.ToList();
            return View(values);
        }
    }
}