using design_pattern.Behavoir_Pattern.solve.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.Behavoir_Pattern.solve.concrete
{
   public  class ResizeOperation : IOperation
    {
         public void Apply(ImageElement element)
        {

            Console.WriteLine("ImageElement");
        }

        public void Apply(TextElement element)
        {

            Console.WriteLine("TextElement");
        }

        
    }
}
