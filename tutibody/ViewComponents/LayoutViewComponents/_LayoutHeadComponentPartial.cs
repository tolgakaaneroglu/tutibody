using Microsoft.AspNetCore.Mvc;

namespace tutibody.ViewComponents.LayoutViewComponents
{
    public class _LayoutHeadComponentPartial : ViewComponent
    {
      

        public IViewComponentResult Invoke()
        {
          
            return View();
        }
    }
}
