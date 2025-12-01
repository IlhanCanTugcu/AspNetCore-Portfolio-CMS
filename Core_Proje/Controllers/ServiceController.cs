using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());

        public IActionResult Index()
        {
            ViewBag.v1 = "Yetenek Listesi";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Listesi";
            ViewBag.link = "/Service/Index";

            var values = serviceManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
            ViewBag.v1 = "Hizmetler Düzenleme";
            ViewBag.v2 = "Hizmetler";
            ViewBag.v3 = "Hizmetler Düzenleme";
            ViewBag.link = "/Default/index#services";

            var values = serviceManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditService(Service p)
        {
            serviceManager.TUpdate(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddService(int id)
        {
            ViewBag.v1 = "Hizmetler Düzenleme";
            ViewBag.v2 = "Hizmetler";
            ViewBag.v3 = "Hizmetler Düzenleme";
            ViewBag.link = "/Default/index#services";

            var values = serviceManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult AddService(Service p)
        {
            serviceManager.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteService(int id)
        {
            var value = serviceManager.TGetByID(id);
            serviceManager.TDelete(value);
            return RedirectToAction("Index");

        }

    }
}
