using Microsoft.AspNetCore.Mvc;
using tutibody.DAL.Context;
using tutibody.DAL.Entities;

namespace tutibody.Controllers
{
    public class ContactController : Controller
    {
        TutibodyContext tutibodyContext = new TutibodyContext();
        public IActionResult ContactList()
        {
            var values = tutibodyContext.Contacts.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var value = tutibodyContext.Contacts.Find(id);

            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        {
            var value = tutibodyContext.Contacts.Update(contact);
            tutibodyContext.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}