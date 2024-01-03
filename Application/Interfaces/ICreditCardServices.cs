using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Application.Interfaces
{
    public interface ICreditCardServices
    {
        IEnumerable<CreditCard> GetAll();
        CreditCard GetById(Guid id);
        void SaveEntity(CreditCard entity);
        void Update(CreditCard entity);
        void Delete(Guid id);
    }
}
