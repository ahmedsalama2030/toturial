using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocUnity
{
    class MasterCard : ICreaditCard
    {
        public void Charge()
        {
            Console.WriteLine("master Card charge");
        }
    }
}