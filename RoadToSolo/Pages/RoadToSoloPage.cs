using Microsoft.AspNetCore.Components;
using RoadToSolo.Data;
using RoadToSolo.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadToSolo.Pages
{
    public partial class RoadToSoloPage
    {
        public List<Milestone> MilestonesList { get; set; }
        protected override Task OnInitializedAsync()
        {
            InitializeMilestones();

            return base.OnInitializedAsync();
        }

        protected override Task OnAfterRenderAsync(bool firstRender)
        {
            return base.OnAfterRenderAsync(firstRender);
        }

        public void InitializeMilestones()
        {
            MilestonesList = new List<Milestone>()
            {
                new Milestone{ Title="Start Website", IsAchieved=true, AchievedDate="07 Mar 2022" },
                new Milestone{ Title="Project 1", PredictedDate="07 Mar 2022" },
                new Milestone{ Title="Project 2", PredictedDate="07 Mar 2022" },
                new Milestone{ Title="Project 3", PredictedDate="07 Mar 2022" },
                new Milestone{ Title="Project 4", PredictedDate="07 Mar 2022" }
            };
        }
    }
}
