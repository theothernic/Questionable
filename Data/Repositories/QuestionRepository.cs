using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Contexts;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class QuestionRepository : IRepository<Question>
    {

        private readonly DataContext _ctx;

        public QuestionRepository(DataContext ctx)
        {
            _ctx = ctx;
        }
        
        public async Task<IEnumerable<Question>> All()
        {
            return await _ctx.Questions.Include(q => q.Answers).ToListAsync();
        }

        public async Task<Question> Find(Guid id)
        {
            return await _ctx.Questions
                .Include(q => q.Answers)
                .Where(q => q.Id == id)
                .FirstOrDefaultAsync();
        }

        public void Create(Question record)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Question record)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Question record)
        {
            throw new System.NotImplementedException();
        }
        
        
        
        public Task<Question> Find(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Question> Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}