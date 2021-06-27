using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocUnity
{
    class Program
    {
        static void Main(string[] args)
        {
            //UnityContainer container = new UnityContainer();
            //container.LoadConfiguration();
            //Shoper shop = container.Resolve<Shoper>();
            //shop.Charge();
            //Console.ReadKey();
            WindsorContainer container = new WindsorContainer();
            container.Register(Component.For<Shoper>().ImplementedBy<Shoper>());
            container.Register(Component.For<ICreaditCard>().ImplementedBy<VisaCard>());

            Shoper shop = container.Resolve<Shoper>();
            shop.Charge();
             Console.ReadKey();

        }
    }
}
