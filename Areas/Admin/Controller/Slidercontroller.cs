using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using sabashop.Models.Context;
using sabashop.Models.Entities;
using sabashop.Models.VmModels;
namespace sabashop.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly ShopContext db;
         public readonly IWebHostEnvironment  env;
        
        public SliderController(ShopContext _db, IWebHostEnvironment  _env)
        {
            db=_db;
            env = _env;
        }


        public IActionResult ShowListSlider(string id)
        {
            var s = db.tbl_Sliders.OrderByDescending(o=>o.Id).ToList();
            if (s != null)
            {
                
                if (id != null)
                {
                    ViewBag.msg = id;
                }


                ViewBag.show = s;
            }
          return View();
        }

        public IActionResult DeletSlider(int id)
        {
            var s = db.tbl_Sliders.SingleOrDefault(p=>p.Id == id);
            db.tbl_Sliders.Remove(s);
            db.SaveChanges();
            string msg = "حذف با موفقیت انجام شد .";
          return RedirectToAction("ShowListSlider" , new { id = msg});
        }



        public IActionResult GoToUpdate(int id)
        {
            var s = db.tbl_Sliders.SingleOrDefault(p=>p.Id == id);
            if (s!= null)
            {
                Vm_Slider t= new Vm_Slider()
                {
                    Id = s.Id,
                    Image= s.Image,
                    LinkTO = s.LinkTO
                };
                return View(t);
            }
            return View();
        }
         public async Task<IActionResult> Update(Vm_Slider l)
         {
             string  msg;
             if (l != null)
             {
                 var s = db.tbl_Sliders.SingleOrDefault(p=>p.Id == l.Id);
                 if (l.Img != null)
                 {
                    string FileExtension1 = Path.GetExtension (l.Img.FileName);
                    string NewFileName = String.Concat (Guid.NewGuid ().ToString (), FileExtension1);
                    var path = $"{env.WebRootPath}\\fileupload\\Slider\\{NewFileName}";
                    using (var stream = new FileStream (path, FileMode.Create))
                    {
                        await l.Img.CopyToAsync (stream);
                    }
                    s.Image = NewFileName;
                 }
                 if (l.LinkTO != null)
                 {
                     s.LinkTO = l.LinkTO;
                 }
                 db.tbl_Sliders.Update(s);
                 db.SaveChanges();
                 msg = "اپدیت با موفیت انجام شد .";
             }else
             {
                 msg = "لطفا ورودی های خود را چک نمایید.";
             }
             return RedirectToAction("ShowListSlider" , new { id = msg});
         }



         public IActionResult GoTOAdd()
         {
           return View();
         }
         



         
         public async Task<IActionResult> AddSlider(Vm_Slider l)
         {
            string  msg;
            if (l != null && l.Img != null)
            {

                Tbl_Slider b= new Tbl_Slider();
                b.LinkTO = l.LinkTO;


                // upload image
                 
                    string FileExtension1 = Path.GetExtension (l.Img.FileName);
                    string NewFileName = String.Concat (Guid.NewGuid ().ToString (), FileExtension1);
                    var path = $"{env.WebRootPath}\\fileupload\\Slider\\{NewFileName}";
                    using (var stream = new FileStream (path, FileMode.Create))
                    {
                        await l.Img.CopyToAsync (stream);
                    }


                b.Image = NewFileName;



                 db.tbl_Sliders.Add(b);
                 db.SaveChanges();
                 msg = "افزودن با موفیت انجام شد .";
            }
            else
            {
                 msg = "لطفا ورودی های خود را چک نمایید.";
            }
             return RedirectToAction("ShowListSlider" , new { id = msg});
         }


        
    }
}