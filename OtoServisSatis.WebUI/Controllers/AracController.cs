using Microsoft.AspNetCore.Mvc;
using OtoServisSatis.Entities;
using OtoServisSatis.Service.Abstract;

namespace OtoServisSatis.WebUI.Controllers
{
    public class AracController : Controller
    {
        private readonly IService<Arac> _serviceArac;

        public AracController(IService<Arac> serviceArac)
        {
            _serviceArac = serviceArac;
        }

        public async Task<IActionResult>Index(int Id)
        {
            var model = await _serviceArac.FindAsync(Id);

            return View(model);
        }
    }
}
