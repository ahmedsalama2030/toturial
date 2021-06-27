using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.Behavoir_Pattern.concrete
{
    public   class PhotoshopEditor 
    {
        List<Element> elements = new List<Element>();
        public void Use(Element element)
        {
            elements.Add(element);
        }
        public  void Resize()
        {
            foreach (var item in elements)
            {
                item.Resize();
            }
        }
        public void Crop()
        {
            foreach (var item in elements)
            {
                item.Crop();
            }
        }
        public void Delete()
        {
            foreach (var item in elements)
            {
                item.Delete();
            }
        }
    }
}
