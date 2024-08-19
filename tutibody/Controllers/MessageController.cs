using Microsoft.AspNetCore.Mvc;
using tutibody.DAL.Context;
using tutibody.DAL.Entities;


namespace tutibody.Controllers
{
	public class MessageController : Controller
    {
        TutibodyContext tutibodyContext = new TutibodyContext();

        public IActionResult Inbox()
		{
			var value = tutibodyContext.Messages.ToList();
			return View(value);
		}
		public IActionResult ChangeIsReadToTrue(int id)
		{
			var value = tutibodyContext.Messages.Find(id);
			value.IsRead=true;
			tutibodyContext.SaveChanges();
			return RedirectToAction("Inbox");
		}	
		public IActionResult ChangeIsReadToFalse(int id)
		{
			var value = tutibodyContext.Messages.Find(id);
			value.IsRead=false;
			tutibodyContext.SaveChanges();
			return RedirectToAction("Inbox");
		}
		public IActionResult DeleteMessage(int id)
		{
			var value = tutibodyContext.Messages.Find(id);
			tutibodyContext.Messages.Remove(value);
			tutibodyContext.SaveChanges();
			return RedirectToAction("Inbox");
		}
		public IActionResult MessageDetail(int id)
		{
			var value = tutibodyContext.Messages.Find(id);
            return View(value);
        }
        [HttpGet]
        public IActionResult CreateMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateMessage(Message p)
        {
            p.SendDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			p.IsRead = false;
            tutibodyContext.Messages.Add(p);
            tutibodyContext.SaveChanges();
            return RedirectToAction("Index", "Default");
        }
    }
}
