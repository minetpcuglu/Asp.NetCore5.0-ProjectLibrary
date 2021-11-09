using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_ProjectLibrary.Controllers
{
   
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Admin p)
        {
            Context c = new Context();
            var datavalue = c.Admins.FirstOrDefault(x => x.AdminMail == p.AdminMail &&
            x.AdminPassword == p.AdminPassword);
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.AdminMail)
                };
                var userIndetity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIndetity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Book");
            }
            else
            {
                return View();
            }

        }
       
    }
}

