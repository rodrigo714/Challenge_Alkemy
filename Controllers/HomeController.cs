using Challenge_Alkemy.Data;
using Challenge_Alkemy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Challenge_Alkemy.Controllers
{
    public class HomeController : Controller
    {
        private Challenge_AlkemyContext db = new Challenge_AlkemyContext();
        private List<Posts> result;

        public ActionResult Index()
        {
            result = db.Posts.OrderByDescending(p => p.Fecha_Creacion).ToList();

            return View(result);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}