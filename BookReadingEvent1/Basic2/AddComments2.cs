using BookReadingEvent1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Basic2
{
    public class AddComments2
    {
        public void AddComment(Comment comment)
        {
            using(BookReadingContext context = new BookReadingContext())
            {
                context.Comments.Add(comment);
                context.SaveChanges();
            }
        }
    }
}