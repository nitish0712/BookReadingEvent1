using BookReadingEvent1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Basic2
{
    public class MyEvents2
    {
        public IEnumerable<Event> GetMyEvents(string userName)
        {


            using (BookReadingContext db = new BookReadingContext())
            {


                var evt = (from e in db.Events
                           where e.UserId == userName
                           select e).ToList();

                return evt;
            }

        }
    }
}