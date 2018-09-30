using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using asp_hw10_js.Models;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;

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

        [HttpGet]
        public string JsonData()
        {
            var data = JsonConvert.SerializeObject(_context.Customers.Include(e => e.Employment).ToList());
            //var data = Json(_context.Customers, JsonRequestBehavior.AllowGet);
            return data;
        }

        [HttpGet]
        public void Delete(int Id)
        {
            var record = _context.Customers.SingleOrDefault(c => c.Id == Id);
            if (record != null)
            {
                _context.Customers.Remove(record);
                _context.SaveChanges();
            }
            else
            {
                throw new HttpRequestException();
            }

        }
    }
}