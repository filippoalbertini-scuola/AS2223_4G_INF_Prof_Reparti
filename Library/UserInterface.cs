using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class UserInterface : Employee
    {
        int previousExperiences;

        public UserInterface(string name, string lastName, int previousExperiences) : base(name, lastName)
        {
            this.previousExperiences = previousExperiences;
        }
    }
}
