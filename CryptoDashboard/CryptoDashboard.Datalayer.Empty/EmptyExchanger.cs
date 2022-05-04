using CryptoDashboard.Datalayer.Abstraction.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Empty
{
    internal class EmptyExchanger : Exchanger
    {
        public EmptyExchanger(string name, string description) : base(name, description)
        {
        }

        public static EmptyExchanger Exchanger => new("Vide", "Pour tester");
    }
}
