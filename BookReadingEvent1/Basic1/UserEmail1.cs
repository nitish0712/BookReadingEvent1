using BookReadingEvent1.Basic2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Basic1
{
    public class UserEmail1
    {
        public string GetUserEmail(string UserName)
        {
            return new UserEmail2().GetUserEmail(UserName);
        }
    }
}