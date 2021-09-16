﻿using BookReadingEvent1.Basic2;
using BookReadingEvent1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Basic1
{
    public class UserValidation1
    {
        UserValidation2 userValidation = new UserValidation2();

        public bool UserExists(User user)
        {
            if (userValidation.UserExists(user))
            {
                if (userValidation.IsValid(user))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
    }
}