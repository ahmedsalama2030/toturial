using design_pattern.Behavoir_Pattern.solve.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.Behavoir_Pattern.solve.concrete
{
    public class ImageElement : IElement
    {
        public void Execute(IOperation Operation)
        {
             Operation.Apply(this);
        }
    }
}
