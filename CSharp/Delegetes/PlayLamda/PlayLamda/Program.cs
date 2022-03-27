using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayLamda
{
    class Program
    {
        delegate int tMath(int a, int b);
        static void Main(string[] args)
        {

           
            

            Console.WriteLine("End");
            Console.ReadKey();

        }
        static void Test2()
        {
            tMath mm = new tMath(Smat);
            
            Console.WriteLine(mm(12, 15));
            //==================
            Func<int, int, int> s;
            s = (x, y) => x + y;
            Console.WriteLine(s(12, 15));

        }
        static int  Smat(int a, int b)
        {
            return a + b;

        }
        static void Test1()
        {
            //tMath m = delegate (int x, int y)  { Console.WriteLine("Start"); return x * y; };
            tMath m = (x, y) =>
            {
                Console.WriteLine("Start");
                int? p = 0;
                return x * y + p ?? 0;
            };

            Console.WriteLine(m(4, 2));
          
        }
    }
}
