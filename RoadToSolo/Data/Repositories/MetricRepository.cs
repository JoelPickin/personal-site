using Microsoft.AspNetCore.Components;
using RoadToSolo.Data.Interfaces;
using RoadToSolo.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadToSolo.Data.Repositories
{
    public class MetricRepository : IRepository<Metric>
    {
        [Inject]
        private CalculationService _calculationService { get; set; } = new CalculationService();
        private List<Metric> _metrics { get; set; }

        private double runway;
        private double daysUntilLeave;

        public MetricRepository()
        {
            runway = _calculationService.GetRunwayDays();
            daysUntilLeave = _calculationService.GetDaysLeftAtWork();
            _metrics = InitializeMetrics();
        }

        private List<Metric> InitializeMetrics()
        {
            return new List<Metric>()
            {
                new Metric { Title = "Days Runway Remaining", Value= $"{runway}" },
                new Metric { Title = "Days Until I Leave", Value=$"{daysUntilLeave}" },
                new Metric { Title = "Overall Revenue", Value="£0" },
                new Metric { Title = "MRR", Value="£0" },
                new Metric { Title = "ARR", Value="£0" },
                new Metric { Title = "Projects Created", Value="2" },
                new Metric { Title = "Community Members", Value="240" }
            };
        }

        public List<Metric> GetAll()
        {
            return _metrics;
        }

        public Metric GetSingleById(int id)
        {
            throw new NotImplementedException();
        }

        public Metric GetSingleByName(string name)
        {
            return _metrics.FirstOrDefault(x => x.Title.ToLower() == name.ToLower());            
        }
    }
}
