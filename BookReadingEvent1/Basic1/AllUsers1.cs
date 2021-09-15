using BookReadingEvent1.Basic2;
using BookReadingEvent1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Basic1
{
    public class AllUsers1
    {
        public IEnumerable<User> GetUsers
        {
            get
            {
                IEnumerable<User> users;
                AllUsers2 getEventsDAL = new AllUsers2();

                users = getEventsDAL.GetUsers;
                return users;
            }
        }
    }
}