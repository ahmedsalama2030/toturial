using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.structure_pattern.Decorator
{
    public abstract class ShapDecorator : Shap
    {
        protected Shap decoratedShape;
        public ShapDecorator(Shap decoratedShape)
        {
            this.decoratedShape = decoratedShape;
        }
        public virtual void draw()
        {
            decoratedShape.draw();
        }
    }
}
