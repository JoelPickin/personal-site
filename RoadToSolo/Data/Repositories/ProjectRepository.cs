using RoadToSolo.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadToSolo.Data.Repositories
{
    public class ProjectRepository : IRepository<Project>
    {
        private List<Project> _projectList { get; set; } = new List<Project>
        {
          
        };

        public List<Project> GetAll()
        {
            return _projectList;
        }

        public Project GetSingleById(int id)
        {
            return _projectList.FirstOrDefault(x => x.Id == id);
        }

        public Project GetSingleByName(string name)
        {
            return _projectList.FirstOrDefault(x => x.Title.ToLower() == name.ToLower());
        }
    }
}
