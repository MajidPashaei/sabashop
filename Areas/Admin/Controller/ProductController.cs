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
    public class ProductController : Controller
    {
        private readonly ShopContext db;
         public readonly IWebHostEnvironment  env;
        
        public ProductController(ShopContext _db, IWebHostEnvironment  _env)
        {
            db=_db;
            env = _env;
        }

        // ---------------------------------------ADD
            public IActionResult GotoAdd()
            {
                return View();
            }
            public IActionResult Add()
            {
                return View();
            }





        // ---------------------------------------Update
        public IActionResult Update()
        {
            return View();
        }




        // ---------------------------------------Show *
        public IActionResult Show()
    {
        var s= db.tbl_Products.ToList();
        if (s != null)
        {
            List<Vm_ShowProduct> sh=new List<Vm_ShowProduct>();
            foreach (var item in s)
            {
                var cat = db.tbl_Categories.SingleOrDefault(p=>p.Id== item.CategoryId);
                var site = db.tbl_SiteCategories.SingleOrDefault(p=>p.Id== item.SiteCategoryId);
                var images= db.tbl_MoreImageProducts.Where(p=>p.IdProduct == item.Id).ToList();
                List<Vm_MoreImageProduct> more = new List<Vm_MoreImageProduct>();
                if (images != null)
                {
                    foreach (var item1 in images)
                    {
                        Vm_MoreImageProduct  ne= new Vm_MoreImageProduct()
                        {
                            Id= item1.Id,
                            Image= item1.Image,
                            IdProduct = item1.IdProduct
                        };
                        more.Add(ne);
                    }
                }
                Vm_ShowProduct ad= new Vm_ShowProduct()
                {
                    Id              = item.Id,
                    Name            = item.Name,
                    CategoryName    = cat.Name + "=>" + cat.FatherName + "=>" + cat.GrandFatherName,
                    SiteCategory    = site.Name,
                    price           = item.Price,
                    Count           = item.Count,
                    offer           = item.Offer,
                    MoreImage       = more,
                    Image           = item.Image,
                };
                sh.Add(ad);
            }
            ViewBag.Show=sh.OrderByDescending(p=>p.Id);
        }
        return View();
    }


        // ---------------------------------------Delete *
        public IActionResult Delete(int id)
        {
            //------------remove more image
                var img= db.tbl_MoreImageProducts.Where(p=>p.IdProduct==id).ToList();
                if (img != null)
                {
                    foreach (var item in img)
                    {
                        db.tbl_MoreImageProducts.Remove(item);
                    }
                }
            //----------remove favorite
                var favorite= db.tbl_Favorites.Where(p=>p.IdProduct==id).ToList();
                if (favorite != null)
                {
                    foreach (var item in favorite)
                    {
                        db.tbl_Favorites.Remove(item);
                    }
                }
            // ------------remove kala
                var s=db.tbl_Products.SingleOrDefault(p=>p.Id==id);
                db.tbl_Products.Remove(s);
            
            // ------------ savechanges    
                db.SaveChanges();
    
    
            return RedirectToAction("Show");
        }

    
    
    

        
        
        
    }
}