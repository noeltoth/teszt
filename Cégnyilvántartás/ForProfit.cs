using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cégnyilvántartás
{
    class ForProfit : Firm, IBuyStock
    {
        public ForProfit(string name, string address) : base(name, address)
        {
        }

        public ForProfit(string name) : base(name)
        {
        }

        public void Buy()
        {
            Console.WriteLine("Részvényt veszek");
        }

        public override void WriteDescription()
        {
            Console.WriteLine("Pénzt termelek a tulajdonosnak");
        }
    }
}