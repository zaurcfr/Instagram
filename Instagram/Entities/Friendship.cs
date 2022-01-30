using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Instagram.Entities
{
    public enum Status
    {
        Accepted,
        Pending,
        Canceled,
        Rejected
    }

    public class Friendship
    {
        public int TargetUserId { get; set; }
        public User TargetUser { get; set; }
        public int DestinationUserId { get; set; }
        public User DestinationUser { get; set; }
        public Status Status { get; set; }
    }
}
