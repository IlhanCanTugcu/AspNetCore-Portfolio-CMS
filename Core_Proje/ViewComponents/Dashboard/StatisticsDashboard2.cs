using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class StatisticsDashboard2 : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            DateTime stajBitis = new DateTime(2026, 1, 18);
            DateTime bugun = DateTime.Now;
            TimeSpan kalanZaman = stajBitis - bugun;

            ViewBag.v1 = kalanZaman.Days / 7 + " Hafta" + " " + kalanZaman.Days % 7 + " Gün";
            ViewBag.v2 = c.Messages.Count();
            ViewBag.v3 = c.Services.Count();
            return View();
        }
    }
}
