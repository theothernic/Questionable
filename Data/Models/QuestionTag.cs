using System;
using System.Collections.Generic;

namespace Data.Models
{
    public class QuestionTag
    {
        public Guid QuestionId { get; set; }
        public Guid TagId { get; set; }


        public Question Question { get; set; }
        public Tag Tag { get; set; }
        }
}