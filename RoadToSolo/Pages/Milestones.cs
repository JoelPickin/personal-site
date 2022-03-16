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
                new Milestone{ Title="Release Project 1", MilestoneIndicator="1️⃣" },
                new Milestone{ Title="Release Project 2", MilestoneIndicator="2️⃣" },
                new Milestone{ Title="Release Project 3", MilestoneIndicator="3️⃣" },
                new Milestone{ Title="Release Project 4", MilestoneIndicator="4️⃣" },
                new Milestone{ Title="First dollar made", MilestoneIndicator="💰" },
                new Milestone{ Title="Web 3 Project", MilestoneIndicator="🚀" },
                new Milestone{ Title="Video Game Project", MilestoneIndicator="🎮" },
                new Milestone{ Title="Community Project", MilestoneIndicator="👥" },
                new Milestone{ Title="Amazon Alexa Skill", MilestoneIndicator="🗣️" },
            };
        }
    }
}
