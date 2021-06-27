using design_pattern.Behavoir_Pattern.example_solve_2.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.Behavoir_Pattern.example_solve_2.concrete
{
    class PlaceOrder : IElement
    {
        public void Execute(IOperation Operation)
        {
            Console.WriteLine("sucess payment");
        }
    }
}
