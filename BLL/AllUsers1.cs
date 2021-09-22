using System;
using System.Collections.Generic;
using Common;
using DataLayer;
namespace BusinessLayer
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
