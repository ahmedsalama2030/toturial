using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.Behavoir_Pattern.concrete
{
    public  class Element
    {
        public void Resize()
        {
            Console.WriteLine("Resize");
        }
        public void Crop()
        {
            Console.WriteLine("Crop");
        }
        public void Delete()
        {
            Console.WriteLine("Delete");
        }
    }
}
