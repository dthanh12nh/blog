using Microsoft.AspNetCore.Mvc;

using PostRepository = TH.Blog.Repositories.Post;
using AddPostModel = TH.Blog.Core.Models.AddPost;
using EditPostModel = TH.Blog.Core.Models.EditPost;

namespace TH.Blog.Presentation.Apis
{
    [Route("[controller]")]
    public class Post : Controller
    {
        PostRepository _postRepository;

        public Post()
        {
            _postRepository = new PostRepository();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_postRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            return Ok(_postRepository.GetById(id));
        }

        [HttpPost]
        public void Add([FromBody]AddPostModel post)
        {
            _postRepository.Add(post);
        }

        [HttpPut("{id}")]
        public void Edit(long id, [FromBody]EditPostModel post)
        {
            _postRepository.Edit(id, post);
        }

        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _postRepository.Delete(id);
        }
    }
}
