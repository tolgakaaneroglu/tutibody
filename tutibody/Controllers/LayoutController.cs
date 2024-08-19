using Microsoft.AspNetCore.Mvc;

namespace tutibody.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
