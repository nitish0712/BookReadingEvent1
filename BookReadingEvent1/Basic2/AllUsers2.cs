using BookReadingEvent1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Basic2
{
    public class AllUsers2
    {
        public IEnumerable<User> GetUsers
        {
            get
            {
                using (BookReadingContext context = new BookReadingContext())
                {
                    IEnumerable<User> users = (from u in context.Users
                                               select u).ToList();
                    return users;
                }
            }
        }
    }
}