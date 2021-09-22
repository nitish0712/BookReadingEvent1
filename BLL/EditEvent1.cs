using Common;
using DAL;
using System.Collections.Generic;

namespace BusinessLayer
    {
    public class EditEvent1
        {
        public bool EditEvent(Event evt )
            {
            List<Invitation> invitations = new List<Invitation>();

            if (evt.InviteByEmail != null)
                {
                var invited = evt.InviteByEmail.Split(',');
                Invitation invitation = new Invitation();
                if (invited != null)
                    {


                    foreach (var item in invited)
                        {
                        invitation.Email = item;
                        invitation.EventId = evt.EventId;
                        }

                    invitations.Add(invitation);
                    }
                }
            EditEvent2 editEvent = new EditEvent2();

            return editEvent.EditEvent(evt,invitations) ? true : false;

            }

        }
    }
