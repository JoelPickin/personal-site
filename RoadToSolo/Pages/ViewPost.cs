using Microsoft.AspNetCore.Components;
using RoadToSolo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadToSolo.Pages
{
    public partial class ViewPost
    {
        [Parameter]
        public string PostId { get; set; }

        public List<Post> PostList { get; set; }
        public Post Post { get; set; }

        protected override Task OnInitializedAsync()
        {
            InitializePostList();
            Post = PostList.FirstOrDefault(p => p.Id == int.Parse(PostId));

            return base.OnInitializedAsync();
        }

        private void InitializePostList()
        {
            PostList = new List<Post>()
            {
                new Post{Id=1, Title="Test Post 1", SubHeading="This is a test post 1", Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec risus erat, efficitur a accumsan id, facilisis at sapien. Sed scelerisque urna et massa blandit blandit. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Sed non magna ullamcorper, rhoncus augue nec, iaculis lectus. Maecenas ultrices dictum mauris, non feugiat erat ullamcorper at. Etiam vel elementum orci, ac sodales lacus. Sed aliquet nisl nec felis scelerisque, in hendrerit neque interdum."},
                new Post{Id=2, Title="Test Post 2", SubHeading="This is a test post 2", Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec risus erat, efficitur a accumsan id, facilisis at sapien. Sed scelerisque urna et massa blandit blandit. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Sed non magna ullamcorper, rhoncus augue nec, iaculis lectus. Maecenas ultrices dictum mauris, non feugiat erat ullamcorper at. Etiam vel elementum orci, ac sodales lacus. Sed aliquet nisl nec felis scelerisque, in hendrerit neque interdum."},
                new Post{Id=3, Title="Test Post 3", SubHeading = "This is a test post 3", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec risus erat, efficitur a accumsan id, facilisis at sapien. Sed scelerisque urna et massa blandit blandit. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Sed non magna ullamcorper, rhoncus augue nec, iaculis lectus. Maecenas ultrices dictum mauris, non feugiat erat ullamcorper at. Etiam vel elementum orci, ac sodales lacus. Sed aliquet nisl nec felis scelerisque, in hendrerit neque interdum." },
                new Post{Id=4, Title="Test Post 4", SubHeading="This is a test post 4", Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec risus erat, efficitur a accumsan id, facilisis at sapien. Sed scelerisque urna et massa blandit blandit. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Sed non magna ullamcorper, rhoncus augue nec, iaculis lectus. Maecenas ultrices dictum mauris, non feugiat erat ullamcorper at. Etiam vel elementum orci, ac sodales lacus. Sed aliquet nisl nec felis scelerisque, in hendrerit neque interdum."},
                new Post{Id=5, Title="Test Post 5", SubHeading = "This is a test post 5", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec risus erat, efficitur a accumsan id, facilisis at sapien. Sed scelerisque urna et massa blandit blandit. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Sed non magna ullamcorper, rhoncus augue nec, iaculis lectus. Maecenas ultrices dictum mauris, non feugiat erat ullamcorper at. Etiam vel elementum orci, ac sodales lacus. Sed aliquet nisl nec felis scelerisque, in hendrerit neque interdum." },
            };
        }
    }
}
