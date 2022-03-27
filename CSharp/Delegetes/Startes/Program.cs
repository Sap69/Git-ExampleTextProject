using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegat1
{

    class Program
    {
        public delegate string MyDelegat(string test);
        static void Main(string[] args)
        {

            Test1();
            Test2();
            Test3();
           Console.ReadLine();
        }
        static void Test3()
        {
            MyDelegat _delegat = (Name) =>
            {
                return "Лямбда-оператор " + Name;
            };
            string strOut = _delegat.Invoke(" Alex");

            Console.WriteLine(strOut);
        }
        static void Test2()
        {
            MyDelegat _delegat = delegate(string Name) { return "Анонимныый метод " + Name; };
            string strOut = _delegat.Invoke( " Alex");
            Console.WriteLine(strOut);
        }
       static  public void Test1()
        {
            Delegat1.SimpleDelegat.delegat01 _delegat = new SimpleDelegat.delegat01();
           //  форма обьявления
            MyDelegat MyDelegat = new Program.MyDelegat(_delegat.Metod1);
            string strOut = MyDelegat.Invoke("Alex");
            Console.WriteLine(strOut);
            //  форма обьявления
            MyDelegat = MyStatic;
            strOut = MyDelegat("Biss");
            Console.WriteLine(strOut);

        }
        static public string MyStatic(string Name)
        {
            return "othe metod " + Name;
        }
    }
}
