using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadToSolo.Data
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubHeading { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
