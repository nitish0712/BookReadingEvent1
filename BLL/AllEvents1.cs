using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using DAL;
namespace BusinessLayer
    {
    public class AllEvents1
        {
        public IEnumerable<Event> GetEvents
            {
            get
                {
                IEnumerable<Event> events;
                AllEvents2 getEvents = new AllEvents2();

                 events = getEvents.GetEvents;
                 return events;
                }
            }

        }
    }
