using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class AboutController : Controller
    {
        AboutManager AboutManager = new AboutManager(new EfAboutDal());

        public IActionResult Index()
        {
            var value = AboutManager.TGetList().FirstOrDefault();

            if (value != null)
            {
                return RedirectToAction("EditAbout", "About", new { id = value.AboutID });
            }
            return View();
        }

        [HttpGet]
        public IActionResult EditAbout(int id)
        {
            ViewBag.v1 = "Hakkımda Düzenleme";
            ViewBag.v2 = "Hakkımda";
            ViewBag.v3 = "Hakkımda Düzenleme";
            ViewBag.link = "/Default/Index#about";

            var values = AboutManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditAbout(About p)
        {
            AboutManager.TUpdate(p);
            return RedirectToAction("index", "Default");
        }

    }
}
