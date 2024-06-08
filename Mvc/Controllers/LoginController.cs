using Microsoft.AspNetCore.Mvc;
using Mvc.Models.context;
using Mvc.Models.dtos;
using Mvc.Models.entity;
using Mvc.Util;

namespace Mvc.Controllers
{
    public class LoginController : Controller
    {

        public IActionResult loginPage()
        {

            return View();
        }

        [HttpPost]
        public IActionResult validLogin(LoginRequestDto dto)
        {
            NorthwindContext context = new NorthwindContext();

            JwtManager jwtManager = new JwtManager();

            Auth auth=context.Auth
            .SingleOrDefault(auth => auth.Mail == dto.Email && auth.Password == dto.Password);

            if (auth == null)
            {
                return View("loginPage");
            }

            string token =jwtManager.CreateToken(auth.Id);


            ViewBag.Token = token;


            return RedirectToAction("Index", "Home");
        }



    }
}
