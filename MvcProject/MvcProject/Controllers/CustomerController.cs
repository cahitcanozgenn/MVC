using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcProject.Models.Entity;

namespace MvcProject.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        MvcProjectDBEntities db = new MvcProjectDBEntities();
        public ActionResult Index()
        {
            var values = db.customer.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCustomer(customer customer)
        {
            db.customer.Add(customer);
            db.SaveChanges();
            return View();
        }
    }
}