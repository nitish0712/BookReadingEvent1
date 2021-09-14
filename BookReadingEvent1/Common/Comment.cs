using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Common
{
    public class Comment
    {
        public int CommentId { get; set; }

        public string CommentAdded { get; set; }

        public DateTime Date { get; set; }

        public int EventId { get; set; }

        public virtual Event Event { get; set; }
    }
}