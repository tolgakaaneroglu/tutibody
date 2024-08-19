using Microsoft.AspNetCore.Mvc;
using tutibody.DAL.Context;

namespace tutibody.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        TutibodyContext tutibodyContext = new TutibodyContext();

        public IViewComponentResult Invoke()
        {
            var values = tutibodyContext.Skills.ToList();
            return View(values);
        }
    }
}

