using BookReadingEvent1.Basic2;
using BookReadingEvent1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Basic1
{
    public class EditEvent1
    {
        public bool EditEvent(Event evnt)
        {
            List<Invitations> invitations = new List<Invitations>();

            if(evnt.InviteByEmail != null)
            {
                var invited = evnt.InviteByEmail.Split(',');
                Invitations invitation = new Invitations();

                if(invited != null)
                {
                    foreach(var item in invited)
                    {
                        invitation.Email = item;
                        invitation.EventId = evnt.EventId;
                    }
                    invitations.Add(invitation);
                }

            }
            EditEvent2 editEvent = new EditEvent2();

            return editEvent.EditEvent(evnt, invitations) ? true : false;
        }
    }
}