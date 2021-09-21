using BookReadingEvent1.Basic2;
using BookReadingEvent1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Basic1
{
    public class Comments1
    {
        public IEnumerable<Comment> GetComments(int eventId)
        {
            IEnumerable<Comment> comments = null;

            var query = from c in (new Comments2().GetComments(eventId))
                        orderby c.Date
                        select c;

            if (query != null)
            {
                comments = query.ToList();
            }
            return comments;
        }
    }
}