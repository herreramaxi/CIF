using CIF.Common.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CIF.Controllers
{
    public class HomeController : Controller
    {
        private IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }


        // GET: Home
        public ActionResult Index()
        {
            return View(_userService.GetAll());
        }
    }
}