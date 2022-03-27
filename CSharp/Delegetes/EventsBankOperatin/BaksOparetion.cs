using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delegate03
{
    public class BaksOparetion
    {

        public delegate int Operation();
        public event Operation NoMone;
        public int Mone { get; private set; }
        public BaksOparetion(int Mone)
        {
            this.Mone = Mone;

        }
        public int CashSet(int Cash)
        {
            if (Cash < Mone)
            {
                Mone -= Cash;
            }
            else
            {
                NoMone();
            }

            return Mone;
        }
    }
}
