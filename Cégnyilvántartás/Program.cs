using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cégnyilvántartás
{
    class Program
    {
    
        
        static void Main(string[] args)
        {
            // 1. feladat
            NonProfit nonProfit = new NonProfit("Vöröskereszt");
            nonProfit.Address = "Budapest, 1051 Budapest, Arany J. u. 31.";
            ForProfit forProfit = new ForProfit("Microsoft");
            forProfit.Address = "Redmond, Washington, United States";
            Broker broker = new Broker("Morgan Stanley");
            broker.Address = "New York City, New York, United States";

            List<Firm> firms = new List<Firm>();
            firms.Add(nonProfit);
            firms.Add(forProfit);
            firms.Add(broker);

            foreach (var firm in firms)
            {
                firm.WriteData();
                firm.WriteDescription();
            }

            // 2.feladat
            ForProfit forProfit2 = new ForProfit("NCsoft");
            forProfit2.Address = " Seongnam, South Korea";
            Broker broker2 = new Broker("Citibank");
            broker2.Address = "New York City, New York, United States";

            List<Firm> firms2 = new List<Firm>();
            firms2.Add(forProfit2);
            firms2.Add(broker2);

            foreach (var f in firms2)
            {
                f.WriteData();
                f.WriteDescription();
                forProfit.Buy();
            }


            //3.feladat


            Pair<string, string> pair = new Pair<string, string>("Gizi", "Béla");
            Console.WriteLine(pair.Item1);
            Console.WriteLine(pair.Item2);

            try
            {
                Create();
                Write();
            }
            catch (Exception)
            {

                Console.WriteLine("Már létezik a file"); ;
            }

            Read();        
            Console.ReadLine();

         
            Console.ReadKey();


        }
        private static void Create()
        {
            using (StreamWriter sw = new StreamWriter(new FileStream(@"..\..\bubuka.txt", FileMode.Create)))
            {
                sw.Flush();
                sw.Close();
            }
        }

        private static void Write()
        {
            using (StreamWriter sw = new StreamWriter(new FileStream(@"..\..\bubuka.txt", FileMode.Open)))

            {
               // sw.BaseStream.Seek(0, SeekOrigin.End);
                sw.Write("Szevasztok Létezik");
                sw.Flush();
                sw.Close();
                throw new Exception();
           
            }
        }
        private static void Read()
        {
            using (StreamReader sw = new StreamReader(new FileStream(@"..\..\bubuka.txt", FileMode.Open)))
            {
                sw.ReadLine();
                sw.Read();         
                sw.Close();
            }

        }
        public static void FoundGetter(bool item)
        {
            if (item == true)
            {
                Console.WriteLine("Meghívták a gettert");
            }
            else
            {
                Console.WriteLine("Nem sikerült feliratkozni");
            }         
        }
    }
}