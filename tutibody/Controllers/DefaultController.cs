using Microsoft.AspNetCore.Mvc;
using tutibody.DAL.Context;
using tutibody.DAL.Entities;

namespace tutibody.Controllers
{
    public class DefaultController : Controller
    {
        TutibodyContext tutibodyContext = new TutibodyContext();
        public IActionResult Index()
        {
            return View();
        }
    }
}