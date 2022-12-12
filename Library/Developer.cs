using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Developer : Employee
    {
        string languages;

        public Developer(string name, string lastname, string languages) : base(name, lastname) 
        {
            this.languages = languages;
        }
    }
}
