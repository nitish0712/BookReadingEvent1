using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace DataLayer
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
