﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using OtoServisSatis.Entities;
using OtoServisSatis.Service.Abstract;
using System.Security.Claims;

namespace OtoServisSatis.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly IService<Kullanici> _service;

        public LoginController(IService<Kullanici> service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> IndexAsync(string email,string password)
        {

            try
            {
                var account = _service.Get(k =>k.Email == email && k.Sifre== password && k.AktifMi==true);

                if (account==null)
                {
                    TempData["Mesaj"] = "Giriş Başarısız";
                }
                else
                {
                    var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name,account.Adi),
                        new Claim("Role","Admin")
                    };

                    var userIdentity = new ClaimsIdentity(claims,"Login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                    await HttpContext.SignInAsync(principal);
                    return Redirect("/Admin");

                }
            }
            catch (Exception)
            {

                TempData["Mesaj"] = "Hata oluştu"; // bir HTTP isteği içerisinde geçici olarak veri saklamak için kullanılan bir mekanizmadır. Bu mekanizma, bir HTTP isteği sırasında bir aksiyon metodunda belirtilen verileri bir sonraki isteğe aktarmanıza olanak sağlar.
            }

            return View();
        }
    }
}