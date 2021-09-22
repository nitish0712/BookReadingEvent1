using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using DataLayer;
namespace BusinessLayer
    {
    public class UserValidation1
        {
        UserValidation2 userValidation = new UserValidation2();
         public bool UserExists(User user)
            {
            if (userValidation.UserExists(user))
                {
                if (userValidation.IsValid(user))
                    return true;
                else
                    return false;
                }
            else
                return false;
            }
         
        }
    }
