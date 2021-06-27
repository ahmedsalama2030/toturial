using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedC
{


    [AttributeUsage(  AttributeTargets.Enum | AttributeTargets.Struct,Inherited =false)]
    class attributes:Attribute
    {
       

        public int X { get; set; }
        public string name { get; set; }

        public attributes(int _X, string _Y)
        {
            this.X = _X;
            this.name = _Y;

        }
        public attributes(int _X):this(_X,null)
        {

        }

        public attributes(string _Y) : this(0, _Y)
        {

        }
        public attributes()
        {

        }

         
    }
}
