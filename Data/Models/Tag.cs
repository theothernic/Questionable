using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Data.Models
{
    public class Tag : Base
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        
        [JsonProperty("questions")]
        public IList<QuestionTag> QuestionTags { get; set; }
    }
}