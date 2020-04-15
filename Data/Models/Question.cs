using System;
using System.Collections.Generic;

namespace Data.Models
{
    public class Question : Base
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        
        public List<Answer> Answers { get; set; }
        public List<Tag> Tags { get; set; }
    }
}