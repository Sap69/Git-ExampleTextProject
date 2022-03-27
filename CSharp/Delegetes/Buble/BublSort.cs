using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace buble
{
    public class BublSort
    {
        public delegate bool Compares(object x, object y);
       static public void SortMetod(object[] Array, Compares op)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (op(Array[j], Array[i]))
                    {
                        object temp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = temp;
                    }
                }
            }

        }
    }
}
