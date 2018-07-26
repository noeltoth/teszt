using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cégnyilvántartás
{
    class NonProfit : Firm 
    {
        public NonProfit(string name, string address) : base(name, address)
        {
        }

        public NonProfit(string name) : base(name)
        {
        }

        public override void WriteDescription()
        {
            Console.WriteLine("Segítek az embereken");
        }
    }
}
