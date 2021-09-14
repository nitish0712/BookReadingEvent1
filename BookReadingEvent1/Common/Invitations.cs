using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Common
{
    public class Invitations
    {
        public int InvitationId { get; set; }
        public string Email { get; set; }
        public int EventId { get; set; }
        public virtual Event Event { get; set; }
    }
}