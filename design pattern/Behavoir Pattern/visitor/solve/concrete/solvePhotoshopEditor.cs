using design_pattern.Behavoir_Pattern.solve.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.Behavoir_Pattern.solve.concrete
{
   public  class solvePhotoshopEditor
    {
        List<IElement> elements = new List<IElement>();
        public void Use(IElement element)
        {
            elements.Add(element);
        }
        public void Execute(IOperation Operation)
        {
            foreach (var item in elements)
            {
                item.Execute(Operation);
            }
        }
    }
}
