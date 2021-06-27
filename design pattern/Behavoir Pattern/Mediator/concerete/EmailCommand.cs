using design_pattern.Behavoir_Pattern.Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.Behavoir_Pattern.Mediator.concerete
{
    public class EmailCommand : IMessageCommand
    {
        public void notify()
        {
            Console.WriteLine("massage email send");
        }
    }
}
