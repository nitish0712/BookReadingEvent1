using BookReadingEvent1.Basic2;
using BookReadingEvent1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Basic1
{
    public class InvitedTo1
    {
        public IEnumerable<Event> GetInvitedTo(string UserEmail)
        {
            InvitedTo2 getMissedEvents = new InvitedTo2();
            IEnumerable<Event> invitedToEvents = getMissedEvents.GetInvitedTo(UserEmail);

            var query = from evnt in invitedToEvents
                        select evnt;

            if (query != null)
            {
                invitedToEvents = query.ToList();
            }
            return invitedToEvents;
        }
    }
}