using BookReadingEvent1.Basic2;
using BookReadingEvent1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Basic1
{
    public class RegisterUser1
    {
        public bool AddUser(User user)
        {
            IEnumerable<User> users = new AllUsers2().GetUsers;
            int count = (from u in users
                         where (u.EmailId == user.EmailId) || (u.UserName == user.UserName)
                         select u).ToList().Count();
            if (count == 0)
            {
                new RegisterUser2().AddUser(user);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}