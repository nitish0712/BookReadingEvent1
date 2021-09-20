using BookReadingEvent1.Basic1;
using BookReadingEvent1.Common;
using BookReadingEvent1.Helper;
using BookReadingEvent1.Models;
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
            IEnumerable<Event> events = allEvents.GetEvents;

            return View(new EventToEventModelHelper().GetEventModels(events));
        }

        public ActionResult MyEvents()
        {
            string UserName = getUserName;
            MyEvents1 getMyEvents = new MyEvents1();
            var myEvents = getMyEvents.GetMyEvents(UserName);
            return View(new EventToEventModelHelper().GetEventModels(myEvents));
        }


        public ActionResult InvitedToEvents()
        {
            string UserEmail = new UserEmail1().GetUserEmail(User.Identity.Name);
            InvitedTo1 invitedTo = new InvitedTo1();
            var invitedEvents = invitedTo.GetInvitedTo(UserEmail);
            return View(new EventToEventModelHelper().GetEventModels(invitedEvents));

        }

        [HttpGet]
        public ActionResult CreateEvent()
        {
            return View();
        }

        [ActionName("CreateEvent")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateEventPost([Bind(Include = "Title, Date, StartTime,Duration,OtherDetails,Type,InviteByEmail,Location,Description")] EventModel model)
        {
            if (ModelState.IsValid)
            {
                model.UserId = User.Identity.Name;
                Event evnt = new EventModelToEventHelper().EventModelToEventMapping(model);


            }
            return View();
        }

    }
}