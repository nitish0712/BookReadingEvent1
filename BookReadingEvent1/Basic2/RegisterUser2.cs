using BookReadingEvent1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Basic2
{
    public class RegisterUser2
    {
        public void AddUser(User user)
        {
            using (BookReadingContext context = new BookReadingContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
                Role role = new Role();
                role.User = user;
                role.AssignedRole = "User";
                context.Roles.Add(role);


                context.SaveChanges();
            }
        }
    }
}