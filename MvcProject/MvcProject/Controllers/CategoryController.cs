using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcProject.Models.Entity;
namespace MvcProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        MvcProjectDBEntities db = new MvcProjectDBEntities();
        public ActionResult Index()
        {
            var values = db.category.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(category category)
        {
            db.category.Add(category);
            db.SaveChanges();
            return View();
        }
    }
}