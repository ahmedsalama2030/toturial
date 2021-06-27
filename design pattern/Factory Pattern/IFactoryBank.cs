using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.Factory_Pattern
{
    interface IFactoryBank
    {
        IBank GetBank(string BankCode);
    }
}
