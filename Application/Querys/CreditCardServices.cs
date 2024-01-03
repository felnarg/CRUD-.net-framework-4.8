using System;
using System.Collections.Generic;
using Application.Interfaces;
using Domain.Models;

namespace Application.Querys
{
    public class CreditCardServices : ICreditCardServices
    {
        private readonly IRepository<CreditCard> _creditCardRepository;
        public CreditCardServices(IRepository<CreditCard> creditCardRepository) 
        {
            _creditCardRepository = creditCardRepository;
        }
        public void Delete(Guid id)
        {
            _creditCardRepository.Delete(id);  
        }

        public IEnumerable<CreditCard> GetAll()
        {
            return _creditCardRepository.GetAll();
        }

        public CreditCard GetById(Guid id)
        {
            return _creditCardRepository.GetById(id);
        }

        public void SaveEntity(CreditCard entity)
        {
            _creditCardRepository.SaveEntityAsync(entity);
        }

        public void Update(CreditCard entity)
        {
            _creditCardRepository.Update(entity);
        }
    }
}
