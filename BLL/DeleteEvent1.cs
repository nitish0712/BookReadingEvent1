using DataLayer;
namespace BusinessLayer
    {
    public class DeleteEvent1
        {
             public void DeleteEvent(int eventId)
            {
            DeleteEvent2 deleteEvent = new DeleteEvent2();
            deleteEvent.DeleteEvent(eventId);
            }
        }
    }
