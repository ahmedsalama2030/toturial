using System;
using System.Collections.Generic;
using System.Text;

namespace IOC
{
  public   class VisaCard : ICreaditCard
    {
        public void Charge()
        {
            Console.WriteLine("visa Card charge");
        }
    }
}