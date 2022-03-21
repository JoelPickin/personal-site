using Microsoft.AspNetCore.Components;
using RoadToSolo.Data;
using RoadToSolo.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadToSolo.Pages
{
    public partial class Posts
    {
        [Inject]
        private PostRepository _postsRepository { get; set; } = default;
        public List<Post> PostList { get; set; }

        protected override Task OnInitializedAsync()
        {
            InitializePostList();

            return base.OnInitializedAsync();
        }

        private void InitializePostList()
        {
            PostList = _postsRepository.GetAll();
        }
    }
}
