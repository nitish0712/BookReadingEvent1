﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
namespace DAL
    {
   public  class UserValidation2
        {
        public bool UserExists(User user)
            {
            using (BookReadingContext db = new BookReadingContext())
                {
                var query = (from u in db.Users
                            where u.UserName.Equals(user.UserName,StringComparison.OrdinalIgnoreCase) 
                            select u).ToList();
                if(query.Count !=0)
                    {
                    return true;
                    }
                return false;
                }
            }
        public bool IsValid(User user)
            {
            using (BookReadingContext db = new BookReadingContext())
                {
                var query = (from u in db.Users
                            where u.Password==user.Password
                            select u).ToList();
                if (query.Count != 0)
                    {
                    return true;
                    }
                return false;
                }
            }
        }
    }
