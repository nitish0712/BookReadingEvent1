using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookReadingEvent1.Controllers
{
    public class BookReadingEventsController : Controller
    {
        string UserName;

        public string getUserName
        {
            get
            {
                if (User.Identity.IsAuthenticated)
                {
                    UserName = User.Identity.Name;
                }
                return UserName;
            }
        }
    }
}