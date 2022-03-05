using RoadToSolo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadToSolo.Pages
{
    public partial class Projects
    {
        public List<Project> ProjectList { get; set; }
        protected override Task OnInitializedAsync()
        {
            InitializeProjects();

            return base.OnInitializedAsync();
        }

        private void InitializeProjects()
        {
            ProjectList = new List<Project>()
            {
                new Project{ Id=0, Title="This Website"}
            };
        }
    }
}
