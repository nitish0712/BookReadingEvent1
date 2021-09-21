using BookReadingEvent1.Basic2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Basic1
{
    public class UserRole1
    {
        public string[] GetRoles(string userName)
        {
            return new UserRole2().GetRoles(userName);
        }
    }
}