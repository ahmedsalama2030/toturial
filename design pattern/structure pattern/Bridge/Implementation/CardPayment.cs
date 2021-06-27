using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.structure_pattern.Bridge.Implementation
{
    public class CardPayment : PaymentBridge
    {
        public override void MakePayment()
        {
            iPaymentSystem.ProcessPayment("card");
        }
    }
}
