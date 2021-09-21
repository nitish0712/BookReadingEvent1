using BookReadingEvent1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Basic2
{
    public class Comments2
    {
        public IEnumerable<Comment> GetComments(int eventId)
        {
            IEnumerable<Comment> comments = null;
            using(BookReadingContext context = new BookReadingContext())
            {
                var query = from c in context.Comments
                            where c.EventId == eventId
                            select c;

                if (query != null)
                {
                    comments = query.ToList();
                }
                return comments;
            }

        }
    }
}