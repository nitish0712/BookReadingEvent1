using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookReadingEvent1.Common;
using BookReadingEvent1.Basic2;

namespace BookReadingEvent1.Basic1
{
    public class AllEvents1
    {
        public IEnumerable<Event> GetEvents
        {
            get
            {
                IEnumerable<Event> events;
                AllEvents2 GetEvents2 = new AllEvents2();

                events = GetEvents2.GetEvents;

                return events;

            }
        }
    }
}