using BookReadingEvent1.Basic2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Basic1
{
    public class DeleteEvent1
    {
        public void DeleteEvent(int eventId)
        {
            DeleteEvent2 deleteEvent = new DeleteEvent2();
            deleteEvent.DeleteEvent(eventId);
        }
    }
}