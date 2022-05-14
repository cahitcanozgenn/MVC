using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcProject.Models.Entity;
namespace MvcProject.Controllers
{
    public class SalesController : Controller
    {
        // GET: Sales
        MvcProjectDBEntities db = new MvcProjectDBEntities();
        public ActionResult Index()
        {
            var values = db.sales.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddSales()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSales(sales sales)
        {
            db.sales.Add(sales);
            db.SaveChanges();
            return View();
        }
    }
}