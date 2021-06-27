using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.structure_pattern.Bridge.Implementation
{
   public class BankCairo : IPaymentSystem
    {
        public void ProcessPayment(string paymentsystem)
        {
            Console.WriteLine($"Ok Bank Cairo"+ paymentsystem);
        }
    }
}
