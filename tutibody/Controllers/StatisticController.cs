using Microsoft.AspNetCore.Mvc;
using tutibody.DAL.Context;

namespace tutibody.Controllers
{
    public class StatisticController : Controller
    {
        TutibodyContext tutibodyContext = new TutibodyContext();

        public IActionResult Index()
        {
            ViewBag.v1 = tutibodyContext.Skills.Count();
            ViewBag.v2 = tutibodyContext.Messages.Count();
            ViewBag.v3 = tutibodyContext.Messages.Where(x=>x.IsRead==false).Count();
            ViewBag.v4 = tutibodyContext.Messages.Where(x=>x.IsRead==true).Count();
            return View();
        }
    }
}
