using System;

namespace IocUnity
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