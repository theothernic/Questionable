using System;

namespace Data.Models
{
    public class Base : IModel
    {
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}