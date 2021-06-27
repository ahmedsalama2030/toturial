using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.structure_pattern.Decorator
{
    public class ShapWithBorder : ShapDecorator
    {
        private string color;
        public ShapWithBorder(Shap decoratedShape,string color) : base(decoratedShape)  { this.color = color; }

        public override   void draw()
        { 
            base.draw();
            setBorder(this.color);
        }

        public void setBorder(string color)
        {
            Console.WriteLine($"border is {color}");
        }

    }
}
