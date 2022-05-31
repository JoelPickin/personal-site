using RoadToSolo.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadToSolo.Data.Repositories
{
    public class MilestoneRepository : IRepository<Milestone>
    {
        private List<Milestone> _milestones { get; set; } = new List<Milestone>()
        {
            new Milestone{ Title="Release Website", IsAchieved=true, AchievedDate="21 Mar 2022" },
            new Milestone{ Title="Release Project 1", IsAchieved=true, MilestoneIndicator="1️⃣" },
            new Milestone{ Title="Release Project 2", MilestoneIndicator="2️⃣" },
            new Milestone{ Title="Release Project 3", MilestoneIndicator="3️⃣" },
            new Milestone{ Title="Release Project 4", MilestoneIndicator="4️⃣" },
            new Milestone{ Title="First Dollar Made", MilestoneIndicator="💵" },
            new Milestone{ Title="Cover My Bills", MilestoneIndicator="💰" },
            new Milestone{ Title="Cover Full Household Bills", MilestoneIndicator="🤑" },
            new Milestone{ Title="Web 3 Project", MilestoneIndicator="🚀" },
            new Milestone{ Title="Video Game Project", MilestoneIndicator="🎮" },
            new Milestone{ Title="Community Project", IsAchieved=true, MilestoneIndicator="👥" },
            new Milestone{ Title="Amazon Alexa Skill", MilestoneIndicator="🗣️" },
            new Milestone{ Title="Info Product", MilestoneIndicator="📗" },
        };

        public List<Milestone> GetAll()
        {
            return _milestones;
        }

        public Milestone GetSingleById(int id)
        {
            throw new NotImplementedException();
        }

        public Milestone GetSingleByName(string name)
        {
            return _milestones.FirstOrDefault(x => x.Title.ToLower() == name.ToLower());
        }
    }
}
