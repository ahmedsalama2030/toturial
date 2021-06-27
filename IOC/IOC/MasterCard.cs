using System;
using System.Collections.Generic;
using System.Text;

namespace IOC
{
    public class MasterCard : ICreaditCard
    {
        public void Charge()
        {
            Console.WriteLine("master Card charge");
        }
    }
}