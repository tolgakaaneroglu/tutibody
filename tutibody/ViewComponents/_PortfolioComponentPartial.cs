using Microsoft.AspNetCore.Mvc;
using tutibody.DAL.Context;

namespace tutibody.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        TutibodyContext tutibodyContext = new TutibodyContext();
        public IViewComponentResult Invoke()
        {
            var values = tutibodyContext.Portfolios.ToList();
            return View(values);
        }
    }
}