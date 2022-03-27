using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delegate03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            BaksOparetion b = new BaksOparetion(1000);
            b.NoMone += () =>
            {
               
                Console.WriteLine("Нет Денег");
               return b.Mone;
            };
           
            i = b.CashSet(100);
            Console.WriteLine(i.ToString());
            i = b.CashSet(500);
            Console.WriteLine(i.ToString());
            i = b.CashSet(500);
            Console.WriteLine(i.ToString());
            Console.ReadKey();
        }

    }
}
