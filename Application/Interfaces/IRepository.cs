using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        Task SaveEntityAsync(T entity);
        void Update(T entity);
        void Delete(Guid id);
    }
}
