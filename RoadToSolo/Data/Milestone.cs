using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadToSolo.Data
{
    public class Milestone
    {
        public string Title { get; set; }
        public string MilestoneIndicator { get; set;  }
        public bool IsAchieved { get; set; }
        public string AchievedDate { get; set; }
        public string PredictedDate { get; set; }
    }
}
