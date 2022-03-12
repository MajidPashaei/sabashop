using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using sabashop.Models.Context;
using sabashop.Models.VmModels;
namespace sabashop.Admin.Controllers
{
    [Area("Admin")]
    public class LogoController : Controller
    {
        private readonly ShopContext db;
         public readonly IWebHostEnvironment  env;
        
        public LogoController(ShopContext _db, IWebHostEnvironment  _env)
        {
            db=_db;
            env = _env;
        }
        public IActionResult GoToAdd(string id)
        {
            var s = db.tbl_Logotitles.SingleOrDefault(p=>p.Id == 1);
            if (s!= null)
            {
                if (id != null)
                {
                    ViewBag.msg = id;
                }
                Vm_Logotitle t= new Vm_Logotitle()
                {
                    Logo = s.Logo,
                    Title = s.Title,
                };
                return View(t);
            }
            return View();
        }
         public async Task<IActionResult> Add(Vm_Logotitle l)
         {
             string  msg;
             if (l != null)
             {
                 var s = db.tbl_Logotitles.SingleOrDefault(p=>p.Id == 1);
                 if (l.Image != null)
                 {
                    string FileExtension1 = Path.GetExtension (l.Image.FileName);
                    string NewFileName = String.Concat (Guid.NewGuid ().ToString (), FileExtension1);
                    var path = $"{env.WebRootPath}\\fileupload\\Logo\\{NewFileName}";
                    using (var stream = new FileStream (path, FileMode.Create))
                    {
                        await l.Image.CopyToAsync (stream);
                    }
                    s.Logo = NewFileName;
                 }
                 if (l.Title != null)
                 {
                     s.Title = l.Title;
                 }
                 db.tbl_Logotitles.Update(s);
                 db.SaveChanges();
                 msg = "اپدیت با موفیت انجام شد .";
             }else
             {
                 msg = "لطفا ورودی های خود را چک نمایید.";
             }
             return RedirectToAction("GoToAdd" , new { id = msg});
         }
         
        
    }
}