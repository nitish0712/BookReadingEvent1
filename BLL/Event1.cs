using Common;
using DataLayer;
namespace BusinessLayer
    {
      public class Event1
        {

          public Event GetEvent(int eventId)
            {
            return new Event2().GetEvent(eventId);
            }
        }
    }
