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
            new Post{Id=1, Title="Test Post 1", SubHeading="This is a test post 1", Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec risus erat, efficitur a accumsan id, facilisis at sapien. Sed scelerisque urna et massa blandit blandit. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Sed non magna ullamcorper, rhoncus augue nec, iaculis lectus. Maecenas ultrices dictum mauris, non feugiat erat ullamcorper at. Etiam vel elementum orci, ac sodales lacus. Sed aliquet nisl nec felis scelerisque, in hendrerit neque interdum."}
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
