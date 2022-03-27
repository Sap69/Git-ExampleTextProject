using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace buble
{
    public class Emploee
    {
        string name;
        int value;
        public Emploee(string Name, int Value)
        {
            this.name = Name;
            this.value = Value;
        }
        static public bool CompEmploeValue(object x, object y)
        {
            bool result= false ;
            Emploee e1 = x as Emploee;
            Emploee e2 = y as Emploee;
            if (e1 != null & e2 != null)
            {
                result = (e1.value < e2.value);
            }
            return result;
        }
        static public bool CompEmploeName(object x, object y)
        {
            bool result = false;
            Emploee e1 = x as Emploee;
            Emploee e2 = y as Emploee;
            if (e1 != null & e2 != null)
            {
                result = (e1.name.Length  < e2.name.Length);
            }
            return result;
        }
        public override string ToString()
        {
            return string.Format("{0}, {1:C}", name, value);
        }

    }
}
