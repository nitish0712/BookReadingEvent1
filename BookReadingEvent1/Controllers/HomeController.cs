using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookReadingEvent1.Common;
using BookReadingEvent1.Models;
using BookReadingEvent1.Basic1;

namespace BookReadingEvent1.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
            //return View();
        //}

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";

            IEnumerable<Event> upcomingEvents;
            IEnumerable<Event> events = new AllEvents1().GetEvents;

            return View();
        }

        //public ActionResult Contact()
        //{
            //ViewBag.Message = "Your contact page.";

            //return View();
        //}
    }
}