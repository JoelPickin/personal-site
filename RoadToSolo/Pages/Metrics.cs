using RoadToSolo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadToSolo.Pages
{
    public partial class Metrics
    {
        public List<Metric> MetricsList { get; set; }

        protected override Task OnInitializedAsync()
        {
            InitializeMetrics();

            return base.OnInitializedAsync();
        }

        private void InitializeMetrics()
        {
            MetricsList = new List<Metric>()
            {
                new Metric { Title = "Days Runway Remaining", Value="196" },
                new Metric { Title = "Days Until I Leave", Value="204" },
                new Metric { Title = "Overall Revenue", Value="£0" },
                new Metric { Title = "MRR", Value="£0" },
                new Metric { Title = "ARR", Value="£0" },
                new Metric { Title = "Projects Created", Value="1" }
            };
        }
    }
}
