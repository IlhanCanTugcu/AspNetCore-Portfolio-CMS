using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IActionResult Index()
        {
            var value = featureManager.TGetList().FirstOrDefault();

            if (value != null)
            {
                return RedirectToAction("EditFeature", "Feature", new { id = value.FeatureID });
            }

            return View();
        }
        [HttpGet]
        public IActionResult EditFeature(int id)
        {
            ViewBag.v1 = "Öne Çıkanlar Düzenleme";
            ViewBag.v2 = "Öne Çıkanlar";
            ViewBag.v3 = "Öne Çıkanlar Düzenleme";
            ViewBag.link = "/Default/Index";

            var values = featureManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditFeature(Feature p)
        {
            featureManager.TUpdate(p);
            return RedirectToAction("EditFeature");
        }
    }
}
