using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cégnyilvántartás
{
   abstract class Firm
    {
        public string Name { get;}
        public string Address { get; set; }

        public Firm(string name, string address)
        {
            Name = name;
            Address = address;
        }

        protected Firm(string name)
        {
            Name = name;
        }


        public void WriteData()
        {
            Console.WriteLine("{0} a cége neve és {1} a címe", Name, Address);
        }

        public abstract void WriteDescription();
    }
}
