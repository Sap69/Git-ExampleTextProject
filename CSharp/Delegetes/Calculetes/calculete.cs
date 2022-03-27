using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delegate1
{
   public class calculete
    {
       
       int a;
       int b;

       public delegate int operations(int a, int b);
       public delegate void EventDelegete();
       public event EventDelegete nullevent;
       operations _op1;
       public calculete(int a, int b)
       {
           this.a = a;
           this.b = b;
       }
       public int Calcoperation(operations _calcOperations)
       {
           int i;
           _op1 = _calcOperations;
           //_op1 = new operations(operation.
           //_op1 = new operations(Soperation.add);
           i= _op1 ( a,  b);
           if (i<=0 ) nullevent();
          

           return i;
       }
    

    }
}
