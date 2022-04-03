using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using sabashop.Models;
using sabashop.Models.Context;
using sabashop.Models.Entities;

namespace sabashop.Controllers
{
    [Authorize]
    public class BuyController : BaseController
    {
        public BuyController(ShopContext _db,IWebHostEnvironment  _env): base(_db,_env)
        {
        }
        public IActionResult AddToBuy(int id)
        {
            var user= db.tbl_Users.SingleOrDefault(p=>p.Phone == User.Identity.GetId());
            if (db.tbl_Factors.Any(p=>p.IdUser==user.Id && p.StatusPay == false))
            {
                var factor = db.tbl_Factors.SingleOrDefault(p=>p.IdUser==user.Id && p.StatusPay == false);
                //-------اضافه کردن کالای انتخاب شده به جزئیات فاکتور بالا
                var product= db.tbl_Products.SingleOrDefault(p=>p.Id ==id);
                var detailproductfactor= db.tbl_DetailFactors.SingleOrDefault(p=>p.RFactor==factor.RFactor && p.IdProduct==product.Id);
                if (detailproductfactor != null)
                {
                    detailproductfactor.Count=+1;
                    detailproductfactor.TotalPrice=(product.Price-(product.Price*product.Offer))*detailproductfactor.Count;
                    db.tbl_DetailFactors.Update(detailproductfactor);
                    db.SaveChanges();
                }else
                {
                    Tbl_DetailFactor detailFactor = new Tbl_DetailFactor();
                    detailFactor.IdUser=user.Id;
                    detailFactor.IdProduct=product.Id;
                    detailFactor.Count=1;
                    detailFactor.TotalPrice=product.Price-(product.Price*product.Offer);
                    detailFactor.RFactor=factor.RFactor;
                    db.tbl_DetailFactors.Add(detailFactor);
                    db.SaveChanges();
                }
                return RedirectToAction("index" , "Home");
                
            }
            else
            {
                //-------تولید رندم کد
                Random rnd = new Random();
                long number;
                do
                {
                    number = rnd.Next(10000, 9999999);
                } while (db.tbl_Factors.Any(p=>p.RFactor == number) == true);
                //-----چون فاکتور مدارد تولید یک فاکتور جدید
                Tbl_Factor newfactor = new Tbl_Factor();
                newfactor.CreateTime = DateTime.UtcNow;
                newfactor.IdUser=user.Id;
                newfactor.StatusPay= false;
                newfactor.RFactor=number;
                newfactor.Price= 0 ;
                db.tbl_Factors.Add(newfactor);
                db.SaveChanges();
                //-------پیدا کردن فاکتر ساختع شده
                var factor=db.tbl_Factors.SingleOrDefault(p=>p.IdUser==user.Id && p.StatusPay == false);
                //-------اضافه کردن کالای انتخاب شده به جزئیات فاکتور بالا
                var product= db.tbl_Products.SingleOrDefault(p=>p.Id ==id);
                Tbl_DetailFactor detailFactor = new Tbl_DetailFactor();
                detailFactor.IdUser=user.Id;
                detailFactor.IdProduct=product.Id;
                detailFactor.Count=1;
                detailFactor.TotalPrice=product.Price-(product.Price*product.Offer);
                detailFactor.RFactor=number;
                db.tbl_DetailFactors.Add(detailFactor);
                db.SaveChanges();
                return RedirectToAction("index" , "Home");

            }
        }
    }
}