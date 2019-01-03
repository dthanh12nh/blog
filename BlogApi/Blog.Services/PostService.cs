using Blog.Core.Models;
using Blog.Repositories;
using System.Collections.Generic;

namespace Blog.Services
{
    public class PostService
    {
        PostRepository _postRepository;

        public PostService()
        {
            _postRepository = new PostRepository();
        }

        public IEnumerable<PostModel> GetAll()
        {
            return _postRepository.GetAll();
        }
    }
}
