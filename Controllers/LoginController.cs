using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sabashop.Models.Context;
using sabashop.Models.VmModels;
//using sabashop.Models;

namespace sabashop.Controllers
{
    public class LoginController : BaseController
    {
        public LoginController(ShopContext _db, IWebHostEnvironment _env) : base(_db, _env)
        {
        }

        public IActionResult GoToLogIn(string id)
        {
            if (id != null)
            {
                ViewBag.msg = id;
            }
            return View();
        }


        //img captch
        public FileStreamResult GetCaptchaImage()
        {
            int width = 100;
            int height = 50;
            var captchaCode = Models.Captcha.GenerateCaptchaCode();
            var result = Models.Captcha.GenerateCaptchaImage(width, height, captchaCode);
            HttpContext.Session.SetString("CaptchaCode", result.CaptchaCode);
            string b = HttpContext.Session.GetString("CaptchaCode");
            Stream s = new MemoryStream(result.CaptchaByteData);
            return new FileStreamResult(s, "image/png");
        }
        public IActionResult LogIn(Vm_User g)
        {
            string msg;

            if (Models.Captcha.ValidateCaptchaCode(g.Captcha, HttpContext))
            {
                if (g != null)
                {
                    var find = db.tbl_Users.SingleOrDefault(p => p.Phone == g.Phone);
                    if (find != null)
                    {
                        if (find.Pass == g.Pass)
                        {
                            var claims = new List<Claim>() {
                            new Claim (ClaimTypes.NameIdentifier,find.Phone),
                            new Claim (ClaimTypes.Name, find.Name)
                            };

                            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                            var principal = new ClaimsPrincipal(identity);

                            var properties = new AuthenticationProperties
                            {
                                ExpiresUtc = DateTime.UtcNow.AddYears(1),
                                IsPersistent = true
                            };
                            HttpContext.SignInAsync(principal, properties);


                            return RedirectToAction("index", "Profile");
                        }
                        else
                        {
                            msg = "نام کاربری و پسورد موجود نمیباشد";
                            return RedirectToAction("GoToLogIn", new { id = msg});
                        }
                    }
                    else
                    {
                        msg = "نام کاربری و پسورد موجود نمیباشد";
                        return RedirectToAction("GoToLogIn", new { id = msg});
                    }
                }
                else
                {
                    msg = "کاربر با مشخصات ذکر شده یافت نشد";
                    return RedirectToAction("GoToLogIn", new { id = msg});
                }
                
            }else
            {
                msg = "کد امنیتی را بدرستی وارد کنید";
                return RedirectToAction("GoToLogIn", new { id = msg});
            }
        }
    }
}