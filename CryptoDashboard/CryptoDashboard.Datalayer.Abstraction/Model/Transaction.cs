using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Abstraction.Model
{
    public abstract class Transaction
    {
        protected Transaction(Guid id, TransactionStatus status)
        {
            Id = id;
            Status = status;
        }

        public virtual Guid Id { get; set; }

        public virtual TransactionStatus Status { get; set; }
    }
}
