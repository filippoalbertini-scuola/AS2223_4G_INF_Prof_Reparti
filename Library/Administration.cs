using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Administration : Employee
    {
        string knownSoftwares;

        public Administration(string name, string cognome, string knownSoftwares) : base(name, cognome)
        {
            this.knownSoftwares = knownSoftwares;
        }
    }
}
