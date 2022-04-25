using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Hakkımda sayfasına hoş geldin.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "İletişim sayfasına hoş geldin.";

            return View();
        }
        public ActionResult Project()
        {
            ViewBag.Message = "Projelerim sayfasına hoş geldin.";
            return View();
        }
    }
}