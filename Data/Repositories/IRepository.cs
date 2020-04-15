using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Repositories
{
    public interface IRepository<T> where T : IModel
    {
        Task<IEnumerable<Question>> All();
        Task<T> Find(Guid id);
        Task<T> Find(string id);
        Task<T> Find(int id);
        
        void Create(T record);
        void Update(T record);
        void Delete(T record);

    }
}