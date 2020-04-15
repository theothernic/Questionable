using System;
using System.Collections.Generic;

namespace Data.Models
{
    public class Question : Base
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        
        public virtual IList<Answer> Answers { get; set; }
        
        public IList<QuestionTag> QuestionTags { get; set; }
    }
}