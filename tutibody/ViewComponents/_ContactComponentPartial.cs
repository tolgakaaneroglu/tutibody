using Microsoft.AspNetCore.Mvc;
using tutibody.DAL.Context;

namespace tutibody.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        TutibodyContext tutibodyContext = new TutibodyContext();

        public IViewComponentResult Invoke()
        {
            ViewBag.contactTitle = tutibodyContext.Contacts.Select(a => a.Title).FirstOrDefault();
            ViewBag.contactDescription = tutibodyContext.Contacts.Select(a => a.Description).FirstOrDefault();            
            ViewBag.contactPhone1 = tutibodyContext.Contacts.Select(a => a.Phone1).FirstOrDefault();            
            ViewBag.contactPhone2 = tutibodyContext.Contacts.Select(a => a.Phone2).FirstOrDefault();            
            ViewBag.contactEmail1 = tutibodyContext.Contacts.Select(a => a.Email1).FirstOrDefault();            
            ViewBag.contactEmail2 = tutibodyContext.Contacts.Select(a => a.Email2).FirstOrDefault();            
            ViewBag.contactAddress = tutibodyContext.Contacts.Select(a => a.Address).FirstOrDefault();                        
            return View();
        }
       
    }
}