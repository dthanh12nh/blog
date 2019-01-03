using Blog.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers
{
    [Route("[controller]")]
    public class PostsController : Controller
    {
        PostService _postService;

        public PostsController()
        {
            _postService = new PostService();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new string[] { "Post 1", "Post 2" });
        }

        [HttpGet("{id}")]
        public IActionResult Get(uint id)
        {
            return Ok($"Post {id}");
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(uint id, [FromBody]string value)
        {

        }

        [HttpDelete("{id}")]
        public void Delete(uint id)
        {

        }
    }
}
