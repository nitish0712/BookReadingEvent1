using Common;
using System.Collections.Generic;
using DataLayer;
using System.Linq;


namespace BusinessLayer
    {
    public class Comments1
        {
             public IEnumerable<Comment> GetComments(int eventId)
            {
            IEnumerable<Comment> comments=null;
             
            var query = from c in (new Comments2().GetComments(eventId))
                        orderby c.Date
                        select c;
            if(query!=null)
                {
                comments = query.ToList();
                }
            return comments;      
            }
        }
    }
