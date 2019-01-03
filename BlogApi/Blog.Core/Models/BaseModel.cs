using System;

namespace Blog.Core.Models
{
    public abstract class BaseModel
    {
        public uint Id { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
