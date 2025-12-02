using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList : ViewComponent
    {
        MessageManager messageManager2 = new MessageManager(new EfMessageDal());
        public IViewComponentResult Invoke()
        {

            var values = messageManager2.TGetList().Where(x => x.Status == true)
                .OrderByDescending(x => x.MessageID).Take(3).ToList();

            ViewBag.count = values.Count();

            return View(values);
        }
    }
}
