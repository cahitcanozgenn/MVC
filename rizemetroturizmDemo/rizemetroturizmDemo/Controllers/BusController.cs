using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using rizemetroturizmDemo.Models.Entity;

namespace rizemetroturizmDemo.Controllers
{
    public class BusController : Controller
    {
        // GET: Bus
        metroturizmDBEntities db = new metroturizmDBEntities();
        public ActionResult Index()
        {
            var values = db.bus.ToList();
            return View(values);

        }
    }
}