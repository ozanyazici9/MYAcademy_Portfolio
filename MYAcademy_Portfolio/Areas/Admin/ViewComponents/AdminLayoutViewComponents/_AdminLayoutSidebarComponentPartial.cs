using Microsoft.AspNetCore.Mvc;

namespace MYAcademy_Portfolio.Areas.Admin.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
//_AdminLayoutSidebarComponentPartial sınıfı bir viewcomponent bu sınıf otomatik olarak
//views / shared / components / _AdminLayoutSidebarComponentPartial / default.cshtml i bulup onu döndürüyor.