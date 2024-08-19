using Microsoft.AspNetCore.Mvc;
using tutibody.DAL.Context;

namespace tutibody.ViewComponents
{
    public class _AboutComponentPartial: ViewComponent
    {
        TutibodyContext tutibodyContext = new TutibodyContext();

        public IViewComponentResult Invoke()
        {
          ViewBag.aboutTitle=tutibodyContext.Abouts.Select(a => a.Title).FirstOrDefault();
          ViewBag.aboutSubDescription=tutibodyContext.Abouts.Select(a => a.SubDescription).FirstOrDefault();
          ViewBag.aboutDetail=tutibodyContext.Abouts.Select(a => a.Details).FirstOrDefault();
            return View();
        }
    }
}
