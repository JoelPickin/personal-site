using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadToSolo.Data
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CoverImage { get; set; }
        public decimal Cost { get; set; }
        public decimal Revenue { get; set; }
        public string Why { get; set; }
        public string How { get; set; }
        public string Next { get; set; }
    }
}
