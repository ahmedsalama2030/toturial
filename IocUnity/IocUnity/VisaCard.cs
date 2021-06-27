using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocUnity
{
    public class VisaCard : ICreaditCard
    {
        public void Charge()
        {
            Console.WriteLine("visa Card charge");
        }
    }
}