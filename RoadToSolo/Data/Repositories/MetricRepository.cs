using RoadToSolo.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadToSolo.Data.Repositories
{
    public class MetricRepository : IRepository<Metric>
    {
        private List<Metric> _metrics { get; set; } = new List<Metric>()
        {
            new Metric { Title = "Days Runway Remaining", Value="196" },
            new Metric { Title = "Days Until I Leave", Value="204" },
            new Metric { Title = "Overall Revenue", Value="£0" },
            new Metric { Title = "MRR", Value="£0" },
            new Metric { Title = "ARR", Value="£0" },
            new Metric { Title = "Projects Created", Value="1" }
        };

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
