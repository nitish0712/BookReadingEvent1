
using System.Collections.Generic;
using Common;

namespace DataLayer
    {
     public class CreateEvent2
        {
            public void CreateEvent(Event evt,List<Invitation> invitations)
            {
           
            using (BookReadingContext context = new BookReadingContext())
                {

                context.Events.Add(evt);
                context.SaveChanges();
                     int id = evt.EventId;
                foreach (var item in invitations)
                    {
                    item.EventId = id;
                    context.Invitations.Add(item);
                    }
                context.SaveChanges();
               
                }
            
            }
        }
    }
