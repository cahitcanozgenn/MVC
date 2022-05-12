using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using rizemetroturizmDemo.Models.Entity;

namespace rizemetroturizmDemo.Controllers
{
    public class ExpeditionsController : Controller
    {
        // GET: Expeditions
        metroturizmDBEntities db = new metroturizmDBEntities();
        public ActionResult Index()
        {
            var values = db.expeditions.ToList();
            return View(values);
        }
    }
}