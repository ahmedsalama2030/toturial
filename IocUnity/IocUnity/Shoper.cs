using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocUnity
{
    internal class Shoper
    {
        private readonly ICreaditCard card;

        public Shoper(ICreaditCard card)
        {
            this.card = card;
        }

        internal void Charge()
        {
            card.Charge();
        }
    }
}