using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sabashop.Models;
using sabashop.Models.Context;

namespace sabashop.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(ShopContext _db,IWebHostEnvironment  _env): base(_db,_env)
        {
        }

        public IActionResult Index()
        {
            saver();
            var s= db.tbl_Products.ToList();
            if (s!= null)
            {
                ViewBag.Show=s;
            }
            
            return View();
        }

        public IActionResult AddBuy(int id)
        {

            return View();
        }
        
    }
}
