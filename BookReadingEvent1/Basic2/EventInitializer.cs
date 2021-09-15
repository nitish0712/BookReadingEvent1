﻿using System.Data.Entity;
using BookReadingEvent1.Common;
using System.Collections.Generic;
using System;

namespace BookReadingEvent1.Basic2
{
    public class EventInitializer : DropCreateDatabaseAlways<BookReadingContext>
    {
        protected override void Seed(BookReadingContext context)
        {
            var users = new List<User>
            {
                new User{UserName="Mayank Gupta" , EmailId="mayankgupta@nagarro.com" , Password="12345678" },
                new User{UserName="Nitish Kumar" , EmailId="nitishkumar@nagarro.com" , Password="12345678"},
                new User{UserName="Praveen" , EmailId="praveen@nagarro.com" , Password="12345678" },
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
            var events = new List<Event>
                {
               new Event{ Title="Basics of Competetive Programming",Date=DateTime.Now, Location="Gurugram", Duration=4, StartTime=DateTime.Now, Description=" GUIDE TO COMPETETIVE PROGRAMMING",OtherDetails=null,Type=EventType.PRIVATE,InviteByEmail=null,UserId="Nitish Kumar"  }
               };
            events.ForEach(s => context.Events.Add(s));
            context.SaveChanges();
            var roles = new List<Role>
                {
                new Role{AssignedRole="User",UserId="Mayank Gupta"},
                new Role{AssignedRole = "Admin", UserId = "Nitish Kumar" },
                new Role{AssignedRole="User",UserId="Praveen"},
            };
            roles.ForEach(s => context.Roles.Add(s));
            context.SaveChanges();
        }
    }
}