using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class helloController : Controller
    {

        // GET: /hello/
        public ActionResult Index()
        {
            var test = new List<string>()
            {
                "Làm quen với MVC",
                "Làm quen với Controller",
                "Làm quen với View"
            };
            ViewBag.Test = test;
            return View();
        }
        //public string show()
        //{
        //    return "helloWorld";
        //}
	}
}