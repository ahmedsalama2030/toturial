using System;

namespace IOC
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