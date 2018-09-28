using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using asp_hw10_js.Models;
using System.Data.Entity;

namespace asp_hw10_js.Controllers
{
    public class HomeController : Controller
    {
        private Models.AppContext _context;

        public HomeController()
        {
            _context = new Models.AppContext();
        }
        public ActionResult Index()
        {

            return View(_context.Customers.Include(e=>e.Employment).ToList());
        }
    }
}