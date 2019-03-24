using BaseEntity = TH.Blog.Core.Entities.Base;

namespace TH.Blog.Core.Entities
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
    }
}
