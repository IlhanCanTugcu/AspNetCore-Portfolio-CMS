using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class ProjectList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
