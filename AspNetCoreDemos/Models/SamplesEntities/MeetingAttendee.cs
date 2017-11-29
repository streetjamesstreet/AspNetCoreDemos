using System;
using System.Collections.Generic;

namespace AspNetCoreDemos.Models
{
    public partial class MeetingAttendee
    {
        public int MeetingID { get; set; }
        public int AttendeeID { get; set; }

        public virtual Meeting Meeting { get; set; }
    }
}
