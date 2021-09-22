using System.Data.Entity;
using Common;
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
                new User{UserName="Ankit Jaitak" , EmailId="ankit.jaitak@nagarro.com" , Password="12345" },
                new User{UserName="Rishav Salodhia" , EmailId="rishav.salodhia@nagarro.com" , Password="12345"},
                new User{UserName="Kunal Garg" , EmailId="kunal.garg@nagarro.com" , Password="12345" },
               };
            users.ForEach(s => bookReadingContext.Users.Add(s));
            bookReadingContext.SaveChanges();
            var events = new List<Event>
                {
               new Event{ Title="Three mistakes of my life",Date=DateTime.Now, Location="Plot 13", Duration=3, StartTime=DateTime.Now, Description=" A GOOD BOOK 1",OtherDetails=null,Type=EventType.PRIVATE,InviteByEmail=null,UserId="Kavan Patel"  }
               };
            events.ForEach(s => bookReadingContext.Events.Add(s));
            bookReadingContext.SaveChanges();
            var roles = new List<Role>
                {
                new Role{AssignedRole="Admin",UserId="Ankit Jaitak"},
                new Role{AssignedRole="User",UserId="Ankit Jaitak"},
                new Role{AssignedRole="User",UserId="Rishav Salodhia"},
                new Role{AssignedRole="User",UserId="Kunal Garg"},
          
            };
            roles.ForEach(s => bookReadingContext.Roles.Add(s));
            bookReadingContext.SaveChanges();
            }
        }
    }
