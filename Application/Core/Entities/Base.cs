using System;

namespace TH.Blog.Core.Entities
{
    public abstract class Base
    {
        public long Id { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
