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

                if(new CreateEvent1().CreateEvent(evnt))
                {
                    return RedirectToAction("About", "Home");
                }

                ViewBag.Message = "This title already exists";
                return View(model);

            }
            return View();
        }


        public ActionResult ViewEvent(int eventId)
        {
            Event1 evnt = new Event1();
            EventModel eventModel = new EventToEventModelHelper().EventToEventModelMapping(evnt.GetEvent(eventId));
            if(eventModel.InviteByEmail != null)
            {
                eventModel.Count = eventModel.InviteByEmail.Split(',').Length;
            }
            else
            {
                eventModel.Count = 0;
            }
            ViewBag.DisplayDescription = (eventModel.Description != null) ? true : false;
            ViewBag.DisplayOtherDetails = (eventModel.OtherDetails != null) ? true : false;
            ViewBag.DisplayDuration = (eventModel.Duration != null) ? true : false;
            ViewBag.DisplayCount = (eventModel.Count != 0) ? true : false;
            ViewBag.DisplayEditLink = ((eventModel.Date.Date > DateTime.Now.Date.Date)
                || ((eventModel.Date.Date == DateTime.Now.Date.Date) && (eventModel.StartTime.Date.TimeOfDay > DateTime.Now.Date.TimeOfDay)))
                && (eventModel.UserId.Equals(User.Identity.Name, StringComparison.OrdinalIgnoreCase) || User.IsInRole("Admin"))
                ? true : false;

            return View(eventModel);
        }

        [HttpGet]
        public ActionResult EditEvent(int eventId)
        {
            Event1 evnt = new Event1();
            EventModel eventModel = new EventToEventModelHelper().EventToEventModelMapping(evnt.GetEvent(eventId));
            return View(eventModel);
        }

        [HttpPost]
        [ActionName("EditEvent")]
        public ActionResult EditEventPost(EventModel eventModel)
        {
            if (ModelState.IsValid)
            {
                EditEvent1 editEvent = new EditEvent1();
                editEvent.EditEvent(new EventModelToEventHelper().EventModelToEventMapping(eventModel));
                return RedirectToAction("ViewEvent", new { eventModel.EventId });
            }
            return View();
        }

        public ActionResult DeleteEvent()
        {
            return View();
        }
    }
}