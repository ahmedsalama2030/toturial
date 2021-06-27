using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.structure_pattern.Bridge.Order
{
    public class CashPayment : PaymentOrder
    {
        public void CreatePayment()
        {
            Console.WriteLine("Cash Payment");
        }
    }
}
