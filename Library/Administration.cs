using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Administration : Employee
    {
        string knownSoftware;

        public Administration(string name, string cognome, string knownSoftware) : base(name, cognome)
        {
            this.knownSoftware = knownSoftware;
        }
    }
}
