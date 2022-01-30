using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Instagram.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Context { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
