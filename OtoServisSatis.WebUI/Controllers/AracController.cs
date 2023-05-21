using Microsoft.AspNetCore.Mvc;
using OtoServisSatis.Entities;
using OtoServisSatis.Service.Abstract;

namespace OtoServisSatis.WebUI.Controllers
{
    public class AracController : Controller
    {
        private readonly ICarService _serviceArac;

        public AracController(ICarService serviceArac)
        {
            _serviceArac = serviceArac;
        }

        public async Task<IActionResult> Index(int Id)
        {
            var model = await _serviceArac.GetCustomCar(Id);

            return View(model);
        }

        [Route("tum-araclarimiz")]
        public async Task<IActionResult> List()
        {
            var model = await _serviceArac.GetCustomCarList(c => c.Satistami);

            return View(model);
        }

        public async Task<IActionResult> Ara(string q)
        {
            
            if (q == null)
            {
                
                return RedirectToAction("Index","Home");
            }
            else
            {
                q = q.Trim();
                var model = await _serviceArac.GetCustomCarList(c => c.Satistami && c.Marka.Adi.Contains(q.Trim()) || c.KasaTipi.Contains(q.Trim()));
                return View(model);
            }


            //return View();
        }
    }
}
