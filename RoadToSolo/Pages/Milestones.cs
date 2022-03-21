using Microsoft.AspNetCore.Components;
using RoadToSolo.Data;
using RoadToSolo.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadToSolo.Pages
{
    public partial class Milestones
    {
        [Inject]
        private MilestoneRepository _milestonesRepository { get; set; } = default;
        public List<Milestone> MilestonesList { get; set; }

        protected override Task OnInitializedAsync()
        {
            InitializeMilestones();

            return base.OnInitializedAsync();
        }

        public void InitializeMilestones()
        {
            MilestonesList = _milestonesRepository.GetAll();
        }
    }
}
