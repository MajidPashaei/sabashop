using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using sabashop.Models;
using sabashop.Models.Context;
using sabashop.Models.Entities;
using sabashop.Models.VmModels;

namespace sabashop.Controllers
{
    public class BaseController : Controller
    {
        public readonly ShopContext db;
        
        public readonly IWebHostEnvironment  env;
        public BaseController(ShopContext _db,IWebHostEnvironment  _env)
        {
            db=_db;
            env= _env;
        }
        public void saver()
        {
            Menu.tp= db.tbl_Logotitles.SingleOrDefault(p=>p.Id == 1);
            Menu.tc = db.tbl_Categories.Where(p=>p.FatherId == 0).ToList();
            Menu.tc1 = db.tbl_Categories.Where(p=>p.GrandFatherId == 0 && p.FatherId != 0).ToList();
            Menu.tc2 = db.tbl_Categories.Where(p=>p.GrandFatherId != 0 && p.FatherId != 0).ToList();
            Menu.ts= db.tbl_SiteCategories.ToList();
            if (User.Identity.IsAuthenticated)
            {
                var s= db.tbl_Factors.SingleOrDefault(p=>p.IdUser.ToString() == User.Identity.GetId() && p.StatusPay == false);
                if (s != null)
                {
                    Menu.df=db.tbl_DetailFactors.Where(p=>p.RFactor==s.RFactor).ToList();
                }
                Menu.df=null;
            }else
            {
                Menu.df=null;
            }
            
        }
    }


    public static class Menu
    {
        public static Tbl_Logotitle tp { get; set; }
        public static List<Tbl_Category>  tc { get; set; }
        public static List<Tbl_Category>  tc1 { get; set; }
        public static List<Tbl_Category>  tc2 { get; set; }
        public static List<Tbl_SiteCategory> ts { get; set; }
        public static List<Tbl_DetailFactor> df{ get; set; }
        
        
    }
    

}