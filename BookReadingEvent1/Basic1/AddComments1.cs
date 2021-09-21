using BookReadingEvent1.Basic2;
using BookReadingEvent1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Basic1
{
    public class AddComments1
    {
        public void AddComment(Comment comment)
        {
            AddComments2 addComments = new AddComments2();
            addComments.AddComment(comment);
        }
    }
}