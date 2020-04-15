using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Data.Models
{
    public class Question : Base
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        
        public IList<Answer> Answers { get; set; }
        
        [JsonProperty("tags")]
        public IList<QuestionTag> QuestionTags { get; set; }
    }
}