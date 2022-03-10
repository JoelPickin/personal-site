using RoadToSolo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadToSolo.Pages
{
    public partial class Milestones
    {
        public List<Milestone> MilestonesList { get; set; }

        protected override Task OnInitializedAsync()
        {
            InitializeMilestones();

            return base.OnInitializedAsync();
        }

        public void InitializeMilestones()
        {
            MilestonesList = new List<Milestone>()
            {
                new Milestone{ Title="Release Website", IsAchieved=true, AchievedDate="07 Mar 2022" },
                new Milestone{ Title="Release Project 1", PredictedDate="07 Mar 2022" },
                new Milestone{ Title="First dollar made!", MilestoneIndicator="$1", PredictedDate="07 Mar 2022" },
                new Milestone{ Title="Release Project 2", PredictedDate="07 Mar 2022" },
                new Milestone{ Title="Release Project 3", PredictedDate="07 Mar 2022" },
                new Milestone{ Title="Release Project 4", PredictedDate="07 Mar 2022" },
                new Milestone{ Title="Web 3 Project", PredictedDate="07 Mar 2022" },
                new Milestone{ Title="Video Game Project", PredictedDate="07 Mar 2022" },
                new Milestone{ Title="Self-taught Developers Project", PredictedDate="07 Mar 2022" },
                new Milestone{ Title="Amazon Alexa Skill", PredictedDate="07 Mar 2022" },
            };
        }
    }
}
