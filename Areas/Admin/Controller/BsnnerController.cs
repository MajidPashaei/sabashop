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
    public class BannerController : Controller
    {
        private readonly ShopContext db;
        public readonly IWebHostEnvironment env;

        public BannerController(ShopContext _db, IWebHostEnvironment _env)
        {
            db = _db;
            env = _env;
        }
        public IActionResult ShowListBanner(string id)
        {
            var s = db.tbl_Baners.OrderByDescending(o => o.Id).ToList();
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
        public IActionResult DeletBanner(int id)
        {
            string msg;
            var s = db.tbl_Baners.SingleOrDefault(p => p.Id == id);
            if (s != null)
            {
                db.tbl_Baners.Remove(s);
                db.SaveChanges();
                msg = "حذف با موفقیت انجام شد .";
            }
            msg = "بنر با مشخصات زیر پیدا نشد";
            return RedirectToAction("ShowListBanner", new { id = msg });
        }
        public IActionResult GoToUpdate(int id)
        {
            var s = db.tbl_Baners.SingleOrDefault(p => p.Id == id);
            if (s != null)
            {
                Vm_Baner t = new Vm_Baner()
                {
                    Id = s.Id,
                    Image = s.Image,
                    LinkTO = s.LinkTO
                };
                return View(t);
            }
            return View();
        }
        public async Task<IActionResult> Update(Vm_Baner l)
        {
            string msg;
            if (l != null)
            {
                if (!db.tbl_Baners.Any(p => p.IDBaner == l.IDBaner))
                {
                    var s = db.tbl_Baners.SingleOrDefault(p => p.Id == l.Id);
                    if (l.Img != null)
                    {
                        string FileExtension1 = Path.GetExtension(l.Img.FileName);
                        string NewFileName = String.Concat(Guid.NewGuid().ToString(), FileExtension1);
                        var path = $"{env.WebRootPath}\\fileupload\\Banner\\{NewFileName}";
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await l.Img.CopyToAsync(stream);
                        }
                        s.Image = NewFileName;
                    }
                    if (l.LinkTO != null)
                    {
                        s.LinkTO = l.LinkTO;
                    }
                    db.tbl_Baners.Update(s);
                    db.SaveChanges();
                    msg = "اپدیت با موفیت انجام شد .";
                }
                else
                {
                    msg = "بنر با این مشخصات موجود میباشد لطفا ابتدا آنرا پاک نمایید.";
                }
            }
            else
            {
                msg = "لطفا ورودی های خود را چک نمایید.";
            }
            return RedirectToAction("ShowListBanner", new { id = msg });
        }
        public IActionResult GoTOAdd()
        {
            return View();
        }
        public async Task<IActionResult> AddBanner(Vm_Baner l)
        {
            string msg;
            if (l != null && l.Img != null)
            {
                if (!db.tbl_Baners.Any(p => p.IDBaner == l.IDBaner))
                {
                    Tbl_Baner b = new Tbl_Baner();
                    b.LinkTO = l.LinkTO;


                    // upload image

                    string FileExtension1 = Path.GetExtension(l.Img.FileName);
                    string NewFileName = String.Concat(Guid.NewGuid().ToString(), FileExtension1);
                    var path = $"{env.WebRootPath}\\fileupload\\Banner\\{NewFileName}";
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await l.Img.CopyToAsync(stream);
                    }


                    b.Image = NewFileName;



                    db.tbl_Baners.Add(b);
                    db.SaveChanges();
                    msg = "افزودن با موفیت انجام شد .";

                }
                else
                {
                    msg = "بنر با این مشخصات موجود میباشد لطفا ابتدا آنرا پاک نمایید.";
                }
            }
            else
            {
                msg = "لطفا ورودی های خود را چک نمایید.";
            }
            return RedirectToAction("ShowListBanner", new { id = msg });
        }



    }
}