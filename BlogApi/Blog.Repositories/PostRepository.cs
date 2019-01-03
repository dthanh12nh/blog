using Blog.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Repositories
{
    public class PostRepository
    {
        public IEnumerable<PostModel> GetAll()
        {
            yield return new PostModel();
        }
    }
}
