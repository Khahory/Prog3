
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProg3_prueba2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FuncionesBasicas()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Mantenimiento()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Otros()
        {
            return View();
        }
    }
}