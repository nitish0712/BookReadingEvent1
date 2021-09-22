using System;
using System.Collections.Generic;
using Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
    {
    public class InvitedTo2
        {
        public IEnumerable<Event> GetInvitedTo(string userEmail)
            {


            using (BookReadingContext db = new BookReadingContext())
                {

                
                IEnumerable<Invitation> invitations = db.Invitations;
                IEnumerable<Event> events = db.Events;
                IEnumerable<Event> invitedTo=null;

                
                var query = from i in invitations
                            join e in events
                            on i.Email equals userEmail
                            where i.EventId==e.EventId
                            select e;
                 if(query!=null)
                    {
                    invitedTo=query.ToList();
                    }

                return invitedTo;
                }

            }
        }
    }
