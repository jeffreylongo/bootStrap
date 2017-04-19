using bootStrap.Models;
using bootStrap.Services;
using bootStrap.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bootStrap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var vm = new ViewModel();
            vm.Teams = new SportsServices().GetTeams();
            return View(vm);
        }

        
    }
}