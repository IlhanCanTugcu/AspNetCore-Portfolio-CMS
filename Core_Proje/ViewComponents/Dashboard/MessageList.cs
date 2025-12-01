using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        MessageManager MessageManager = new MessageManager(new EfMessageDal());
        public IViewComponentResult Invoke()
        {
            var values = MessageManager.TGetList().OrderByDescending(x => x.Date).ToList();
            return View(values);
        }
    }
}
