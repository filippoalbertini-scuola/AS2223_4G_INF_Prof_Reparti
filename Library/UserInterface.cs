using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class UserInterface : Employee
    {
        int anniEsperienza;

        public UserInterface(string nome, string cognome, int anniEsperienza) : base(nome, cognome)
        {
            this.anniEsperienza = anniEsperienza;
        }
    }
}
