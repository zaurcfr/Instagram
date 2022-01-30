using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Instagram.Entities
{
    public class User : Entity
    {
        public List<Post> Posts { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Friendship> TargetFriendships { get; set; }
        public List<Friendship> DestinationFriendships { get; set; }
    }
}
