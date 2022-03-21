using Microsoft.AspNetCore.Components;
using RoadToSolo.Data;
using RoadToSolo.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadToSolo.Pages
{
    public partial class Metrics
    {
        [Inject]
        private MetricRepository _metricsRepository { get; set; } = default;
        public List<Metric> MetricsList { get; set; }

        protected override Task OnInitializedAsync()
        {
            InitializeMetrics();

            return base.OnInitializedAsync();
        }

        private void InitializeMetrics()
        {
            MetricsList = _metricsRepository.GetAll();
        }
    }
}
