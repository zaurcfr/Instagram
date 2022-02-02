using Instagram.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Instagram.Areas.User.Models
{
    public class IndexViewModel
    {
        public List<Entity> Users { get; set; }
        public List<Post> Posts { get; set; }

    }
}
