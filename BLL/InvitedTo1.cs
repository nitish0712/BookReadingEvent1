using System.Collections.Generic;
using System.Linq;
using DAL;
using Common;

namespace BusinessLayer
    {
    public class InvitedTo1
        {

        public IEnumerable<Event> GetInvitedTo(string userEmail)
            {
            
                InvitedTo2 getMissedEventsDAL = new InvitedTo2();

                IEnumerable<Event> invitedToEvents = getMissedEventsDAL.GetInvitedTo(userEmail);
               

                var query = from e in invitedToEvents
                            select e;

                if (query != null)
                    {
                    invitedToEvents = query.ToList();
                    }
           
                return invitedToEvents;
                
            }
        }

    }
