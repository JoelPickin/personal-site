using Microsoft.AspNetCore.Components;
using RoadToSolo.Data;
using RoadToSolo.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadToSolo.Pages
{
    public partial class Projects
    {
        [Inject]
        private ProjectRepository _projectRepository { get; set; } = default;
        public List<Project> ProjectList { get; set; }

        protected override Task OnInitializedAsync()
        {
            InitializeProjects();

            return base.OnInitializedAsync();
        }

        private void InitializeProjects()
        {
            ProjectList = _projectRepository.GetAll();
        }
    }
}
