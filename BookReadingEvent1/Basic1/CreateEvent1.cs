using BookReadingEvent1.Basic2;
using BookReadingEvent1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Basic1
{
    public class CreateEvent1
    {
        public bool CreateEvent(Event evnt)
        {
            IEnumerable<Event> events = new AllEvents1().GetEvents;

            var titleQuery = (from e in events
                              where e.Title.Equals(evnt.Title, StringComparison.OrdinalIgnoreCase)
                              select e).ToList().Count;

            if(titleQuery == 0)
            {
                List<Invitations> invitations = new List<Invitations>();

                if(evnt.InviteByEmail != null)
                {
                    var invited = evnt.InviteByEmail.Split(',');
                    Invitations invitation = new Invitations();
                    if(invited != null)
                    {
                        foreach (var item in invited)
                        {
                            invitation.Email = item;
                            invitation.EventId = evnt.EventId;
                        }
                        invitations.Add(invitation);
                    }

                }
                new CreateEvent2().CreateEvent(evnt, invitations);

                return true;
            }
            else
            {
                return false;
            }

        }
    }
}