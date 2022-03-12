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
    public class CategoryController : Controller
    {
        private readonly ShopContext db;
         public readonly IWebHostEnvironment  env;
        
        public CategoryController(ShopContext _db, IWebHostEnvironment  _env)
        {
            db=_db;
            env = _env;
        }

    #region Add
    
        public IActionResult GoToAddGfather()
        {
            return View();
        }
        public IActionResult AddGfather(Vm_Category k)
        {
            if (k != null)
            {
                Tbl_Category h = new Tbl_Category()
                {
                    Name=k.Name,
                    FatherId=0,
                };
                db.tbl_Categories.Add(h);
                db.SaveChanges();
            }
            return RedirectToAction("Show");
        }

        public IActionResult GoToAddFther()
        {
            var Asli = db.tbl_Categories.Where(p=>p.FatherId == 0 ).ToList();
            if (Asli != null)
            {
                ViewBag.Show = Asli;
            }
            return View();
        }
        public IActionResult AddFther(Vm_Category k)
        {
            if (k != null)
            {
                var split = k.FatherName.Split(",");
                Tbl_Category h = new Tbl_Category()
                {
                    Name=k.Name,
                    FatherId=Convert.ToInt32(split[1]),
                    FatherName=split[0],
                };
                db.tbl_Categories.Add(h);
                db.SaveChanges();
            }
            return RedirectToAction("Show");
        }

        public IActionResult GoToAddchild()
        {
            var Fare = db.tbl_Categories.Where(p=>p.GrandFatherId == 0 && p.FatherId != 0).ToList();
            if (Fare != null)
            {
                ViewBag.Show = Fare;
            }
            return View();
        }
        public IActionResult Addchild(Vm_Category k)
        {
            if (k != null)
            {
                var split = k.FatherName.Split(",");
                var query = db.tbl_Categories.SingleOrDefault(p=>p.Id== Convert.ToInt32(split[1]));
                Tbl_Category h = new Tbl_Category()
                {
                    Name=k.Name,
                    FatherId=Convert.ToInt32(split[1]),
                    FatherName=split[0],
                    GrandFatherName=query.FatherName,
                    GrandFatherId=query.FatherId,
                };
                db.tbl_Categories.Add(h);
                db.SaveChanges();
            }
            return RedirectToAction("Show");
        }
        

    #endregion

    
    #region Show
        public IActionResult Show(string id)
        {
            if (id != null)
            {
                ViewBag.msg = id;
            }
            ViewBag.Show= db.tbl_Categories.ToList();
            return View();
        }
        
        
    #endregion

    
    #region Delete


    public IActionResult Delete(int id)
    {
        string msg ="";
        var s = db.tbl_Categories.Any(p=>p.FatherId == id);
        if (s)
        {
            msg = "این دسته بندی زیر دسته دارد لطغا ابتدا زیر دسته را حذف نمایید.";
        }
        var kala= db.tbl_Products.Any(p=>p.CategoryId == id);
        if (kala)
        {
            
            msg = "این دسته بندی  کالا دارد لطغا ابتدا کالاهایش  را حذف نمایید.";
        }
        if (!s && !kala)
        {
            var del = db.tbl_Categories.SingleOrDefault(p=>p.Id == id);
            db.tbl_Categories.Remove(del);
            db.SaveChanges();
            msg = "حذف با موفقیت انجام شد . ";
        }
        return RedirectToAction("Show" , new{ id=msg} );
    }  
    #endregion
    
    }
}



































































            // List<Vm_Category> AsliL = new List<Vm_Category>();
            // List<Vm_Category> FareL = new List<Vm_Category>();
            // List<Vm_Category> Fare2L = new List<Vm_Category>();



            // var Asli = db.tbl_Categories.Where(p=>p.FatherId == 0 ).ToList();
            // if (Asli != null)
            // {
            //     foreach (var item in Asli)
            //     {       
            //         Vm_Category j = new Vm_Category()
            //         {
            //             Name=item.Name,
            //             FatherName = item.FatherName,
            //             FatherId= item . FatherId,
            //             GrandFatherName = item . GrandFatherName,
            //             GrandFatherId = item . GrandFatherId,

            //         };
            //         AsliL.Add(j);
            //         var fare=db.tbl_Categories.Where(p=>p.FatherId == item.Id ).ToList();
            //         if (fare != null)
            //         {
            //             foreach (var item1 in fare)
            //             {
            //                 Vm_Category w = new Vm_Category()
            //                 {
            //                     Name=item1.Name,
            //                     FatherName = item1.FatherName,
            //                     FatherId= item1.FatherId,
            //                     GrandFatherName = item1.GrandFatherName,
            //                     GrandFatherId = item1.GrandFatherId,
            //                 };
            //                 FareL.Add(w);
            //                 var fare2=db.tbl_Categories.Where(p=>p.FatherId == item1.Id ).ToList();
            //                 if (fare2 != null)
            //                 {
            //                     foreach (var item2 in fare)
            //                     {
            //                         Vm_Category r = new Vm_Category()
            //                         {
            //                             Name=item2.Name,
            //                             FatherName = item2.FatherName,
            //                             FatherId= item2.FatherId,
            //                             GrandFatherName = item2.GrandFatherName,
            //                             GrandFatherId = item2.GrandFatherId,
            //                         };
            //                         Fare2L.Add(r);
            //                     }
            //                 }
            //             }
                        
            //         }


            //     }
            // }




            // ViewBag.Asli= AsliL;
            // ViewBag.FareL= FareL;
            // ViewBag.Fare2L= Fare2L;


            

