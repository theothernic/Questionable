using System;
using System.Collections.Generic;

namespace Data.Models
{
    public class Tag : Base
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        
        public List<Question> Questions { get; set; }
    }
}