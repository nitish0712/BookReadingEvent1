using System.Web.Mvc;
using BusinessLayer;
using BookReading.Models;
using Common;
using BookReading.Helper;
using System.Collections.Generic;
using System;

namespace BookReading.Controllers
    {
    public class BookReadingEventController : Controller
    {

        string UserName;
        public string GetUserName
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
            string UserName=GetUserName;
            MyEventsBL getMyEventsBL = new MyEventsBL();
            var myEvents = getMyEventsBL.GetMyEvents(UserName);
            return View(new EventToEventModelHelper().GetEventModels(myEvents));
            }


       public ActionResult EventsInvitedTo()
            {
            string UserEmail = new UserEmail1().GetUserEmail(User.Identity.Name);
            InvitedTo1 invitedToBL = new InvitedTo1();
            var invitedEvents = invitedToBL.GetInvitedTo(UserEmail);
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
        public ActionResult CreateEventPost([Bind(Include = "Title, Date, StartTime,Duration,OtherDetails,Type,InviteByEmail,Location,Description")]EventModel model)
            {
                if(ModelState.IsValid)
                {
                model.UserId =User.Identity.Name;
                
                Event evt = new EventModelToEventHelper().EventModelToEventMapping(model);

                if(new CreateEvent1().CreateEvent(evt))

                return RedirectToAction("About","Home");

                
                }
            ViewBag.Message = "Title Already exists";
            return View(model);

            }
        
        
       
        public ActionResult ViewEvent(int eventId)
            {
             Event1 evt = new Event1();
            EventModel eventModel = new EventToEventModelHelper().EventToEventModelMapping(evt.GetEvent(eventId));
            if (eventModel.InviteByEmail != null)
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
                &&(eventModel.UserId.Equals(User.Identity.Name,StringComparison.OrdinalIgnoreCase)||User.IsInRole("Admin"))
                ? true : false;
            
            return View(eventModel);
            }

        [HttpGet]
      
        public ActionResult EditEvent(int eventId)
            {
            Event1 eventBL = new Event1();
            EventModel model = new EventToEventModelHelper().EventToEventModelMapping(eventBL.GetEvent(eventId));
            return View(model);
            }
        
        
        [HttpPost]
        [ActionName("EditEvent")]
        
        public ActionResult EditEventPost(EventModel eventModel)
            {
            if (ModelState.IsValid)
                {
                EditEvent1 editEvent = new EditEvent1();
                editEvent.EditEvent(new EventModelToEventHelper().EventModelToEventMapping(eventModel));
                return RedirectToAction("ViewEvent",new { eventModel.EventId});
                }
            else
                return View();
            
            }

        public ActionResult DeleteEvent(int eventId)
            {
            DeleteEvent1 deleteEventBL = new DeleteEvent1();
            deleteEventBL.DeleteEvent(eventId);
            return RedirectToAction("About","Home");
            }

        [HttpGet]
        public ActionResult Comments(int eventId)
            {
            Comments1 commentsBL = new Comments1();
            IEnumerable<Comment> comments= commentsBL.GetComments(eventId);
            return PartialView(new CommentToCommentModelHelper().GetCommentModels(comments));
            }

     
        
        [HttpPost]
        public ActionResult AddCommentsPost([Bind(Include ="EventId,CommentAdded")]CommentModel commentModel)
            {
            commentModel.Date = DateTime.Now;
                if(ModelState.IsValid)
                {
                new AddComments1().AddComment(new CommentModelToCommentHelper().CommentModelToCommentMapping(commentModel));
                }
            return RedirectToAction("ViewEvent",new { commentModel.EventId});
            }
            
    }
}