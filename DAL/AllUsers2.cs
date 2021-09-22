using System;
using System.Collections.Generic;
using System.Linq;
using Common;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
    {
   public class AllUsers2
        {

        public IEnumerable<User> GetUsers
            {
            get
                {
                using (BookReadingContext context = new BookReadingContext())
                    {
                    IEnumerable<User> users = (from u in context.Users
                                                 select u).ToList();
                    return users;
                    }
                }
            }
        }
    }
