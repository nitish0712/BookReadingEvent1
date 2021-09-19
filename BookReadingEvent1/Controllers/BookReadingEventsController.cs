using BookReadingEvent1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookReadingEvent1.Controllers
{
    public class BookReadingEventsController : Controller
    {
        string UserName;

        public string getUserName
        {
            get
            {
                if (User.Identity.IsAuthenticated)
                {
                    UserName = User.Identity.Name;
                }
                return UserName;
            }
        }

        public ActionResult AllEvents()
        {
            AllEvents1 allEvents = new AllEvents1();
            IEnumerable<Event> events = allEvents.getEvents;

            return View(new EventToEventModelHeler().GetEventModels(events));
        }
    }
}