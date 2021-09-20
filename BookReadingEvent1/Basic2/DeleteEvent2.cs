using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Basic2
{
    public class DeleteEvent2
    {
        public void DeleteEvent(int eventId)
        {
            using(BookReadingContext context = new BookReadingContext())
            {
                var query = (from e in context.Events
                            where e.EventId == eventId
                            select e).ToList().First();

                context.Events.Remove(query);
                context.SaveChanges();
            }
        }
    }
}