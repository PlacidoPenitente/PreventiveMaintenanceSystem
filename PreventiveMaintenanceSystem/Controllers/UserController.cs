using PreventiveMaintenanceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PreventiveMaintenanceSystem.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UserController()
        {
            _applicationDbContext = new ApplicationDbContext();
        }

        // GET: User
        public ActionResult Index()
        {
            return View(_applicationDbContext.Users.ToList());
        }
    }
}