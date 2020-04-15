using System;

namespace Data.Models
{
    public class Answer : Base
    {
        public Guid Id { get; set;  }
        public Guid QuestionId { get; set; }
        public string Text { get; set; }
        
        public Question Question { get; set; }
        
    }
}