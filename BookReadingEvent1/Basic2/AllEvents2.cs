using BookReadingEvent1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Basic2
{
    public class AllEvents2
    {
        public IEnumerable<Event> GetEvents
        {
            get
            {
                using (BookReadingContext context = new BookReadingContext())
                {
                    IEnumerable<Event> events = (from e in context.Events select e).ToList();

                    return events;
                }
            }
        }

    }
}