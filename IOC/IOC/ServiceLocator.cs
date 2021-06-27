using System;

namespace IOC
{
    internal class ServiceLocator
    {
          internal T Get<T>()
        {
          
            var x = typeof(T);
            return (T) Activator.CreateInstance(x);

         }
    }
}