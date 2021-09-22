using System.Data.Entity;
using Shared;
using System.Collections.Generic;
using System;

namespace DAL
{
    public class EventInitializer:DropCreateDatabaseIfModelChanges<BookReadingContext>
    {
        protected override void Seed(BookReadingContext bookReadingContext)
        {
            
            var users = new List<User>
            {
                new User{UserName="Nitish Kumar" , EmailId="nitishkumar@nagarro.com" , Password="12345678" },
                new User{UserName="Mayank Gupta" , EmailId="mayankgupta@nagarro.com" , Password="12345678"},
                new User{UserName="Parveen" , EmailId="parveen@nagarro.com" , Password="12345678" }
            };
            users.ForEach(s => bookReadingContext.Users.Add(s));
            bookReadingContext.SaveChanges();
            var events = new List<Event>
            {
                new Event{Title="Introduction to Programming",Date=DateTime.Now, Location="Delhi", Duration=3, StartTime=DateTime.Now, Description="Basics",OtherDetails=null,Type=EventType.PRIVATE,InviteByEmail=null,UserId="Mayank Gupta"  }
            };
            events.ForEach(s => bookReadingContext.Events.Add(s));
            bookReadingContext.SaveChanges();
            var roles = new List<Role>
            {
                new Role{AssignedRole="Admin",UserId="Nitish Kumar"},
                new Role {AssignedRole ="User", UserId = "Nitish Kumar" },
                new Role{AssignedRole="User",UserId="Mayank Gupta"},
                new Role{AssignedRole="User",UserId="Parveen"}
            };
            roles.ForEach(s => bookReadingContext.Roles.Add(s));
            bookReadingContext.SaveChanges();
        }
    }
}
