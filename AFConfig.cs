using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Assignment2.AbstractFactory;
using Assignment2.AbstractFactory.Interfaces;
using Assignment2.AbstractFactory.Models;
using Assignment2.Adapter;
using Assignment2.Adapter.AdapterApp;
using Autofac;

namespace Assignment2
{
    public static class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // Register Main Application
            builder.RegisterType<Application>().As<IApplication>();

            // AbstractFactory
            builder.RegisterType<AbstractFactoryApp>().As<IAbstractFactoryApp>();

            //Adapter
            builder.RegisterType<AdapterApp>().As<IAdapterApp>();
            


            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            //    .Where(i => i.Namespace.Contains("Adapter"))
            //    .As(i => i.GetInterfaces()
            //    .FirstOrDefault(n => n.Name == "I" + i.Name))
            //       .AsImplementedInterfaces();

            return builder.Build();
        }
    }
}
