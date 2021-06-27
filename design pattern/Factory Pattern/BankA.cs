using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.Factory_Pattern
{
   public class BankA: IBank
    {
        public string withdrow()
        {
            return "reqest Bank A";
        }
    }
}
