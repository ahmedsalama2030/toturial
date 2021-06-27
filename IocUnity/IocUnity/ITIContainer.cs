using System;
using System.Collections.Generic;
using System.Linq;

namespace IocUnity
{
    internal class ITIContainer
    {
        private readonly Dictionary<Type, Type> iocDictionary =
             new Dictionary<Type, Type>();

        internal void Register<Tfrom, TTo>()
        {
            iocDictionary[typeof(Tfrom)] = typeof(TTo);

        }
        public T Resolve<T>()
        {
            return (T) Resolve(typeof(T));
        }

        internal object Resolve(Type typefrom)
        {
             if (!iocDictionary.ContainsKey(typefrom))
                throw new Exception(string.Format( "type{typeof} not found", typefrom.Name));
            var typeto = iocDictionary[typefrom];
            var cinfo = typeto.GetConstructors().FirstOrDefault();
            if (cinfo.GetParameters().Count() == 0)
                return   Activator.CreateInstance(typeto);
            List<object> objectparams = new List<object>();

            foreach (var param in cinfo.GetParameters())
            {
                objectparams.Add(Resolve(param.ParameterType));
            }
            return cinfo.Invoke(objectparams.ToArray());
        }
    }
}