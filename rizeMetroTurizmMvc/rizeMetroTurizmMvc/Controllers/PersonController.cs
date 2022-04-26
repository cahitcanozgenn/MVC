using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using rizeMetroTurizmMvc.Models.Entity;

namespace rizeMetroTurizmMvc.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        rizemetroturizmdbEntities1 db = new rizemetroturizmdbEntities1();
        public ActionResult Index()
        {
            var values = db.person.ToList();
            return View(values);
        }
    }
}