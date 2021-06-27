using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.structure_pattern.Bridge
{
  public abstract  class PaymentBridge
    {
        public IPaymentSystem iPaymentSystem;

        public abstract void MakePayment();
    }
}
