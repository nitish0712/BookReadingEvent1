using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookReadingEvent1.Common;
using BookReadingEvent1.Models;
using BookReadingEvent1.Basic1;
using BookReadingEvent1.Helper;

namespace BookReadingEvent1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";

            IEnumerable<Event> upcomingEvents;
            IEnumerable<Event> events = new AllEvents1().GetEvents;
            IEnumerable<Event> missedEvents;

            if (User.Identity.IsAuthenticated)
            {
                upcomingEvents = events.Where(e => (e.Date > DateTime.Now.Date) || ((e.Date == DateTime.Now.Date) && (e.Date.TimeOfDay > DateTime.Now.TimeOfDay))).ToList();
                upcomingEvents = upcomingEvents.Where(e => (e.Type == EventType.PRIVATE && e.UserId == User.Identity.Name) || (e.Type == EventType.PUBLIC)).ToList();
                missedEvents = events.Where(e => (e.Date < DateTime.Now.Date) || ((e.Date == DateTime.Now.Date) && (e.Date.TimeOfDay < DateTime.Now.TimeOfDay))).ToList();
                missedEvents = missedEvents.Where(e => (e.Type == EventType.PRIVATE && e.UserId == User.Identity.Name) || (e.Type == EventType.PUBLIC)).ToList();
            }
            else
            {
                events = events.Where(x => x.Type == EventType.PUBLIC);
                upcomingEvents = events.Where(e => (e.Date > DateTime.Now.Date) || ((e.Date == DateTime.Now.Date) && (e.Date.TimeOfDay > DateTime.Now.TimeOfDay))).ToList();
                upcomingEvents = upcomingEvents.Where(e => e.Type == EventType.PUBLIC).ToList();
                missedEvents = events.Where(e => (e.Date < DateTime.Now.Date) || ((e.Date == DateTime.Now.Date) && (e.Date.TimeOfDay < DateTime.Now.TimeOfDay))).ToList();
                missedEvents = missedEvents.Where(e => e.Type == EventType.PUBLIC).ToList();
            }

            List<IEnumerable<EventModel>> eventModels = new List<IEnumerable<EventModel>>();
            eventModels.Add(new EventToEventModelHelper().GetEventModels(missedEvents));
            eventModels.Add(new EventToEventModelHelper().GetEventModels(upcomingEvents));

            return View(eventModels);
        }

        //public ActionResult Contact()
        //{
            //ViewBag.Message = "Your contact page.";

            //return View();
        //}
    }
}