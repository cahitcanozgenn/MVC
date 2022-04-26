using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using rizeMetroTurizmMvc.Models.Entity;

namespace rizeMetroTurizmMvc.Controllers
{
    public class DegreeController : Controller
    {
        // GET: Degree
        rizemetroturizmdbEntities1 db = new rizemetroturizmdbEntities1();
        public ActionResult Index()
        {
            var values = db.degree.ToList();
            return View(values);
        }
    }
}