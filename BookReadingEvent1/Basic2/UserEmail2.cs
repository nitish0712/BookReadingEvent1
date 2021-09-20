using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Basic2
{
    public class UserEmail2
    {
        public string GetUserEmail(string UserName)
        {
            using(BookReadingContext context = new BookReadingContext())
            {
                string userEmail = (from u in context.Users
                                    where u.UserName == UserName
                                    select u.EmailId).ToList().First();
                return userEmail;
            }
        }
    }
}