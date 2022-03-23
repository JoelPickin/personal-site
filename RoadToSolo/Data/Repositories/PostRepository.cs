using RoadToSolo.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadToSolo.Data.Repositories
{
    public class PostRepository : IRepository<Post>
    {
        private List<Post> _posts = new List<Post>()
        {
            
        };

        public List<Post> GetAll()
        {
            return _posts;
        }

        public Post GetSingleById(int id)
        {
            return _posts.FirstOrDefault(x => x.Id == id);
        }

        public Post GetSingleByName(string name)
        {
            return _posts.FirstOrDefault(x => x.Title.ToLower() == name.ToLower());
        }
    }
}
