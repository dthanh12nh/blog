using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Core.Models
{
    public class PostModel : BaseModel
    {
        public string Title { get; set; }
        public string Desciption { get; set; }
        public string Content { get; set; }
    }
}
