using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Client
    {

        public string Name { get; set; }
        public string firstSurname { get; set; }
        public string secondSurname { get; set; }

        public Client(string name, string fSurname, string sSurname)
        {
            Name = name;
            firstSurname = fSurname;
            secondSurname = sSurname;
        }
    }
}
