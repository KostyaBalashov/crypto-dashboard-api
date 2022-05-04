using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Abstraction.Model
{
    public abstract class TransactionStatus
    {
        protected TransactionStatus(string description)
        {
            Description = description;
        }

        public virtual string Description { get; set; }
    }
}
