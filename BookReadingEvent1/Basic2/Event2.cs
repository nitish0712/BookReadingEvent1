using BookReadingEvent1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Basic2
{
    public class Event2
    {
        public Event GetEvent(int eventId)
        {
            using(BookReadingContext context = new BookReadingContext())
            {
                IEnumerable<Event> events = context.Events;
                Event eventFound = null;
                var query = (from evnt in events
                             where evnt.EventId == eventId
                             select evnt);
                if (query != null)
                {
                    eventFound = query.ToList().First();
                }
                return eventFound;
            }
        }
    }
}