using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.structure_pattern.Decorator
{
    class Rectangle : Shap
    {
        public void draw()
        {
            Console.WriteLine("Rectangle draw");
        }
    }
}
