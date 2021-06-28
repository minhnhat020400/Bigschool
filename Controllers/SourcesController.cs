using Bigschool.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bigschool.Controllers
{
    public class SourcesController : Controller
    {
        public readonly ApplicationDbContext _dbContext;
        // GET: Sources
        public SourcesController() {

            _dbContext = new ApplicationDbContext();
        }

        public ActionResult Create()
        {
            var viewmodel = new SourceViewModel { };

            return View();
        }
    }
}