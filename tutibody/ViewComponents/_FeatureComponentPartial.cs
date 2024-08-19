using Microsoft.AspNetCore.Mvc;
using tutibody.DAL.Context;

namespace tutibody.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        TutibodyContext tutibodyContext = new TutibodyContext();
        public IViewComponentResult Invoke()
        {
            var values = tutibodyContext.Features.ToList();
            return View(values);
        }
    }
}
