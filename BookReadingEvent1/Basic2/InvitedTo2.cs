using BookReadingEvent1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Basic2
{
    public class InvitedTo2
    {
        public IEnumerable<Event> GetInvitedTo(string UserEmail)
        {
            using (BookReadingContext context = new BookReadingContext())
            {
                IEnumerable<Invitations> invitations = context.Invitations;
                IEnumerable<Event> events = context.Events;
                IEnumerable<Event> invitedTo = null;

                var query = from i in invitations
                            join e in events
                            on i.Email equals UserEmail
                            where i.EventId == e.EventId
                            select e;
                if (query != null)
                {
                    invitedTo = query.ToList();
                }
                return invitedTo;
            }
        }
    }
}