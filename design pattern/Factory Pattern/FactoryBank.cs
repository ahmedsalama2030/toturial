using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.Factory_Pattern
{
    public class FactoryBank : IFactoryBank
    {
        public IBank GetBank(string BankCode)
        {
            switch (BankCode)
            {
                case "123456": return  new BankA(); 
                case "111111": return new BankB();
            }
            return null;
        }
    }
}
