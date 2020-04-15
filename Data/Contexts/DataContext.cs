using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {}
        
        private DbSet<Question> Questions { get; set; }
        private DbSet<Tag> Tags { get; set; }
    }
}