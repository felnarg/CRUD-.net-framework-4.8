using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Models
{
    public class CreditCard
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public string Holder { get; set; }
        public decimal Balance { get; set; }
    }
}