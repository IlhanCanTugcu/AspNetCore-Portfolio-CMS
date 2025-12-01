using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class MessageController : Controller
    {
        MessageManager MessageManager = new MessageManager(new EfMessageDal());

        public IActionResult Index()
        {
            ViewBag.v1 = "Mesajlar Listesi";
            ViewBag.v2 = "Mesajlar";
            ViewBag.v3 = "Mesajlar Listesi";
            ViewBag.link = "/Message/Index";
            var values = MessageManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult DeleteMessage(int id)
        {
            var value = MessageManager.TGetByID(id);
            MessageManager.TDelete(value);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatus(int id)
        {
            var value = MessageManager.TGetByID(id);
            if (value.Status == true)
            {
                value.Status = false;
            }
            else
            {
                value.Status = true;
            }
            MessageManager.TUpdate(value);
            return RedirectToAction("Index");
        }
    }
}
