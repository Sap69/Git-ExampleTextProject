using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace buble
{
    class Program
    {
        static void Main(string[] args)
        {
            Emploee[] emp ={
                new Emploee("n01",10),
                new Emploee("n002",100), 
                new Emploee("n0003",11),
                new Emploee("n00004",4),
                new Emploee("n5",1000),
                           };

            foreach (Emploee emploe in emp)
            {
                Console.WriteLine(emploe);
            }
            Console.WriteLine(new string('-', 20));
            BublSort.SortMetod(emp, Emploee.CompEmploeValue);
            foreach (Emploee emploe in emp)
            {
                Console.WriteLine(emploe);
            }

            Console.WriteLine(new string('-', 20));
            BublSort.SortMetod(emp, Emploee.CompEmploeName);
            foreach (Emploee emploe in emp)
            {
                Console.WriteLine(emploe);
            }
            Console.ReadKey();


        }
    }
}
