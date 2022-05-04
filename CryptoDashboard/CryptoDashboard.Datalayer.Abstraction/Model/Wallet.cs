using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Abstraction.Model
{
    public abstract class Wallet
    {
        protected Wallet(string name, Guid id, decimal balance, string currency, DateTimeOffset createdAt)
        {
            Name = name;
            Id = id;
            Balance = balance;
            Currency = currency;
            CreatedAt = createdAt;
        }

        public virtual string Name { get; set; }

        public virtual Guid Id { get; set; }

        public virtual decimal Balance { get; set; }

        public virtual string Currency { get; set; }

        public virtual DateTimeOffset CreatedAt { get; set; }
    }
}
