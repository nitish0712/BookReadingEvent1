using BookReadingEvent1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookReadingEvent1.Basic2
{
    public class EditEvent2
    {
        public bool EditEvent(Event evnt, List<Invitations> invitations)
        {
            using(BookReadingContext context = new BookReadingContext())
            {
                var query = (from i in context.Invitations
                             where i.EventId == evnt.EventId
                             select i);

                context.Invitations.RemoveRange(query.ToList());

                foreach(var item in invitations)
                {
                    item.EventId = evnt.EventId;
                    context.Invitations.Add(item);
                }

                context.SaveChanges();

                context.Entry(evnt).State = EntityState.Modified;
                context.SaveChanges();
                return true;
            }
        }
    }
}