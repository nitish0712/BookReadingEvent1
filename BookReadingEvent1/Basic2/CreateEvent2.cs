using BookReadingEvent1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Basic2
{
    public class CreateEvent2
    {
        public void CreateEvent(Event evnt, List<Invitations> invitations)
        {
            using(BookReadingContext context = new BookReadingContext())
            {
                context.Events.Add(evnt);
                context.SaveChanges();

                var id = evnt.EventId;

                foreach(var item in invitations)
                {
                    item.EventId = id;
                    context.Invitations.Add(item);
                }
                context.SaveChanges();
            }
        }
    }
}