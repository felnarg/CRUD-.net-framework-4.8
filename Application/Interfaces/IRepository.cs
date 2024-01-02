using System;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        void SaveEntity(T entity);
        void Update(T entity);
        void Delete(Guid id);
    }
}
