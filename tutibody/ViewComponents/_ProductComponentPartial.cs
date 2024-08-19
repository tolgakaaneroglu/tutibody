using Microsoft.AspNetCore.Mvc;

namespace tutibody.ViewComponents
{
    public class _ProductComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}