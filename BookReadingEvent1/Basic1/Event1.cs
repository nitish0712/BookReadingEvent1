using BookReadingEvent1.Basic2;
using BookReadingEvent1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Basic1
{
    public class Event1
    {
        public Event GetEvent(int eventId)
        {
            return new Event2().GetEvent(eventId);
        } 
    }
}