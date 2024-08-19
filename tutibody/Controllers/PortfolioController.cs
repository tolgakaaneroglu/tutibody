using Microsoft.AspNetCore.Mvc;
using tutibody.DAL.Context;
using tutibody.DAL.Entities;

namespace tutibody.Controllers
{
    public class PortfolioController : Controller
    {
        TutibodyContext tutibodyContext = new TutibodyContext();
        public IActionResult PortfolioList()
        {
            var values = tutibodyContext.Portfolios.ToList();
            return View(values);
        } 
        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
          var value=  tutibodyContext.Portfolios.Find(id);
            return View(value);
        }  
        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
          var value=  tutibodyContext.Portfolios.Update(portfolio);
            tutibodyContext.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
    }
}
