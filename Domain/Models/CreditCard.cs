using System;

namespace Domain.Models
{
    public class CreditCard
    {
        public Guid Id { get; set; }
        public string CardNumber { get; set; }
        public string Holder { get; set; }
        public decimal Balance { get; set; }
    }
}