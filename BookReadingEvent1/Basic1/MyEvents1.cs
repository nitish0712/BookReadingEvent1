using BookReadingEvent1.Basic2;
using BookReadingEvent1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Basic1
{
    public class MyEvents1
    {
        public IEnumerable<Event> GetMyEvents(string UserName)
        {
            MyEvents2 getMyEvents = new MyEvents2();
            IEnumerable<Event> myEvents = getMyEvents.GetMyEvents(UserName);
            return myEvents;
        }
    }
}