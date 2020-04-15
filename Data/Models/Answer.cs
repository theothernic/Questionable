using System;
using Newtonsoft.Json;

namespace Data.Models
{
    public class Answer : Base
    {
        public Guid Id { get; set;  }
        public string Text { get; set; }
        
        public Guid QuestionId { get; set; }
        
        [JsonIgnore]
        public Question Question { get; set; }
        
    }
}