using Microsoft.AspNetCore.Mvc;
using tutibody.DAL.Context;

namespace tutibody.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        TutibodyContext tutibodyContext = new TutibodyContext();

        public IViewComponentResult Invoke()
        {
            var values = tutibodyContext.Sponsors.ToList();
            return View(values);
        }
    }
}