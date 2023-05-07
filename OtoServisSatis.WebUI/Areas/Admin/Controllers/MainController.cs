using Microsoft.AspNetCore.Mvc;

namespace OtoServisSatis.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")] // bu Controller bir area içinde çalışmaktadır ve bu area içindeki admin klasörünün içinde
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
