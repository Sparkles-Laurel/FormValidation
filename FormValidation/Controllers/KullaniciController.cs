using FormValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormValidation.Controllers {
    public class KullaniciController:Controller {
        [HttpGet]
        public IActionResult Ekle() {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Kullanici kullanici){
            if(!ModelState.IsValid) {
                Response.StatusCode = 400;
                return View(kullanici);
            }
            return Content("Doğrulama başarılı");
        }
    }
}