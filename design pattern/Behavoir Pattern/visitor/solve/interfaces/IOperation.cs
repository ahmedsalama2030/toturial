using design_pattern.Behavoir_Pattern.solve.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.Behavoir_Pattern.solve.interfaces
{ 
    public interface IOperation
{
        void Apply(ImageElement imageElement);  // visit
        void Apply(TextElement textElement);  // visit
    }
}
