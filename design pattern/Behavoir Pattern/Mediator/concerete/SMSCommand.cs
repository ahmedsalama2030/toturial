using design_pattern.Behavoir_Pattern.Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.Behavoir_Pattern.Mediator.concerete
{
    class SMSCommand : IMessageCommand
    {
        public void notify()
        {
            Console.WriteLine("massage sms send");
        }
    }
}