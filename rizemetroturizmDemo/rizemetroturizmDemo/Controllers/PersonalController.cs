using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using rizemetroturizmDemo.Models.Entity;

namespace rizemetroturizmDemo.Controllers
{
    public class PersonalController : Controller
    {
        // GET: Personal
        metroturizmDBEntities db = new metroturizmDBEntities();
        public ActionResult Index()
        {
            var values = db.personal.ToList();
            return View(values);
        }
    }
}