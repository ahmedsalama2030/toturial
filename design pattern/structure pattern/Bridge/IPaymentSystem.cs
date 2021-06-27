using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.structure_pattern.Bridge
{
 public   interface IPaymentSystem
    {
        void ProcessPayment(string paymentsystem);
    }
}
