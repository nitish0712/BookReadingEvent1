using System.Collections.Generic;
using Common;
using DataLayer;

namespace BusinessLayer
    {
    public class MyEventsBL
        {
        public IEnumerable<Event> GetMyEvents(string userName)
            {
           
                MyEvents2 getMyEventsDAL = new MyEvents2();

                IEnumerable<Event> myEvents = getMyEventsDAL.GetMyEvents(userName);
                
                return myEvents;
                
            }

        }
    }
