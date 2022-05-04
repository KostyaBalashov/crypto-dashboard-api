using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Abstraction.Model
{
    public abstract class Exchanger
    {
        protected Exchanger(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public virtual string Name { get; set; }

        public virtual string Description { get; set; }
    }
}
