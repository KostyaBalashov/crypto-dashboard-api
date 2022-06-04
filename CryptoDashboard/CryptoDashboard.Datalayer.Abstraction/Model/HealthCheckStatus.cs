using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Abstraction.Model
{
    public abstract class HealthCheckStatus
    {
        public virtual int StatusCode { get; set; }

        public virtual string Description { get; set; } = string.Empty;
    }
}
