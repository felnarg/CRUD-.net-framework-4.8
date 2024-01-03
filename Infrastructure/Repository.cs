using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;

namespace Infrastructure
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly CreditCardDbContext _context;

        public Repository(CreditCardDbContext context)
        {
            _context = context;
        }

        public void Delete(Guid id)
        {
            T entity = _context.Set<T>().Find(id) ?? throw new Exception("Not Found");
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(Guid id)
        {
            T entity = _context.Set<T>().Find(id);
            return entity ?? throw new Exception("Not Found");
        }

        public async Task SaveEntityAsync(T entity)
        {
            _context.Set<T>().Add(entity); 
            await _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            if(entity.ToString().Any())
            {
                _context.Set<T>().AddOrUpdate(entity);
                _context.SaveChanges();
            }
            else            
                throw new Exception("Not Found");
            
        }
    }
}
