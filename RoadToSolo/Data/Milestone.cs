using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadToSolo.Data
{
    public class Milestone
    {
        public string Title { get; set; }
        public bool IsAchieved { get; set; }
        public DateTime AchievedDate { get; set; }
        public DateTime PredictedDate { get; set; }
    }
}
