using Microsoft.AspNetCore.Mvc;
using OtoServisSatis.Entities;
using OtoServisSatis.Service.Abstract;
using OtoServisSatis.WebUI.Models;
using System.Diagnostics;

namespace OtoServisSatis.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService<Slider> _service;
        private readonly ICarService _serviceArac;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IService<Slider> service, ICarService serviceArac)
        {
            _logger = logger;
            _service = service;
            _serviceArac = serviceArac;
        }

        public async Task<IActionResult> Index()
        {
            var model = new HomePageViewModel()
            {
                Sliders = await _service.GetAllAsync(),
                Araclar = await _serviceArac.GetCustomCarList(a=>a.Anasayfa)
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}