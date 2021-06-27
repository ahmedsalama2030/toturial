using System;
using System.Collections.Generic;
using System.Text;
using design_pattern.Behavoir_Pattern.example_solve_2.interfaces;
 namespace design_pattern.Behavoir_Pattern.example_solve_2.concrete
{
    class SendEmail : IElement
    {
        public void Execute(IOperation Operation)
        {
            Console.WriteLine("sucess payment");
        }
    }
}
