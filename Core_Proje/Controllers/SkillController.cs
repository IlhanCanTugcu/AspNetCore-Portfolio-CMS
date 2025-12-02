using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            var values = skillManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }

        public IActionResult DeleteSkill(int id)
        {
            var value = skillManager.TGetByID(id);
            skillManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult AddSkill(Skill p)
        {
            skillManager.TAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            var values = skillManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditSkill(Skill p)
        {
            skillManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}