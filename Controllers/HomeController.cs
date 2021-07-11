using Bigschool.Models;
using Bigschool.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bigschool.Controllers
{
    public class HomeController : Controller
    {
        public readonly ApplicationDbContext _dbContext;
        
        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var upcommingcourse = _dbContext.soures
                .Include(c => c.Lecturer)
                .Include(c => c.catagory)
                .Where(c => c.DateTime > DateTime.Now).ToList();

            return View(upcommingcourse);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}