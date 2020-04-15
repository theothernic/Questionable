using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts
{
    public class DataContext: DbContext, IDataContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {}
        
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<QuestionTag> QuestionTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<QuestionTag>().HasKey(qt => new {qt.QuestionId, qt.TagId});

            modelBuilder.Entity<QuestionTag>()
                .HasOne<Question>(qt => qt.Question)
                .WithMany(q => q.QuestionTags)
                .HasForeignKey(qt => qt.QuestionId);


            modelBuilder.Entity<QuestionTag>()
                .HasOne<Tag>(qt => qt.Tag)
                .WithMany(tag => tag.QuestionTags)
                .HasForeignKey(qt => qt.TagId);
        }
    }
}