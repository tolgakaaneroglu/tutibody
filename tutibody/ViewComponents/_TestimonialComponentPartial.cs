using Microsoft.AspNetCore.Mvc;
using tutibody.DAL.Context;

namespace tutibody.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        TutibodyContext tutibodyContext = new TutibodyContext();

        public IViewComponentResult Invoke()
        {
            var values = tutibodyContext.Products.ToList();
            return View(values);
        }
    }
}