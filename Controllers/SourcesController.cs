using Bigschool.Models;
using Bigschool.ViewModel;
using Microsoft.AspNet.Identity;
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
        [Authorize]
        
        public ActionResult Create()
        {
            var viewmodel = new SourceViewModel {
                categories = _dbContext.categories.ToList()
            };

            return View(viewmodel);
        }
        [Authorize]
        [HttpPost]
        public ActionResult Create(SourceViewModel viewModel)

        {
            if (!ModelState.IsValid)
            {
                viewModel.categories = _dbContext.categories.ToList();
                return View("Create", viewModel);
            }
            var course = new Soure
            {
                LiecturerId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                catacoryId=viewModel.Category,
                Place= viewModel.Place
            };
            _dbContext.soures.Add(course);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}