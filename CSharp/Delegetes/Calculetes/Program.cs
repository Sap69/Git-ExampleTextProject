using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delegate1
{
    class Program
    {
        delegate void myPrint(string msg);
        static void Main(string[] args)
        {
            //string str;
            //str = "try write";
            //myPrint _print = new myPrint(print);
            //_print(str);
            
            int i;
            calculete colc = new calculete(10, 20);
            colc.nullevent += new calculete.EventDelegete(EventHandlrNull);
          i= colc.Calcoperation(new calculete.operations (Soperation.add));
          print(i.ToString());
          i = colc.Calcoperation(new calculete.operations(Soperation.multiple));
          print(i.ToString());
          i = colc.Calcoperation(Soperation.degree);
          print(i.ToString());
          i = colc.Calcoperation(nOperations);
          print(i.ToString());
           Console.ReadKey();

        }
        static int nOperations(int a, int b)
        {
            return a * b -b* a;
        }
        static void print(string msg)
        {
            Console.WriteLine(msg);

        }
        static void EventHandlrNull()
        {
            Console.WriteLine(" NULL");
        }
    }
}
