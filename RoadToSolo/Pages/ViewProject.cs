using Microsoft.AspNetCore.Components;
using RoadToSolo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadToSolo.Pages
{
    public partial class ViewProject
    {
        [Parameter]
        public string PostId { get; set; }
        public Project Project { get; set; }
        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }
    }
}
