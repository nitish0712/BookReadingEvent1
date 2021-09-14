using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Common
{
    public class Role
    {
        public int RoleId { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public string AssignedRole { get; set; }

    }
}