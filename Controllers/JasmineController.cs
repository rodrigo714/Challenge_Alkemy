using System;
using System.Web.Mvc;

namespace Challenge_Alkemy.Controllers
{
    public class JasmineController : Controller
    {
        public ViewResult Run()
        {
            return View("SpecRunner");
        }
    }
}
