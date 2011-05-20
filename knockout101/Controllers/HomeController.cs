using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using knockout101.Models;

namespace knockout101.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult ks01()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult ks02()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }


        public ActionResult ks03()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        
        public JsonResult Save(Person person)
        {

            var message = string.Format("Saved {0}, {1}", person.FirstName, person.LastName);
            message += string.Format(" with {0} friends ", person.Friends.Count);
            message += string.Format(" ({0} on Twitter)", person.Friends.Where(x => x.IsOnTwitter).Count());

            return Json(new { message });
        }



        public ActionResult About()
        {
            return View();
        }
    }
}
