using Blog.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.IServices
{
    public interface IPostService
    {
        IEnumerable<PostModel> GetAll();
        PostModel GetById(uint id);
    }
}
