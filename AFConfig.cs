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
using Assignment2.Facade;
using Assignment2.Facade.FacadeApp;
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

            //Facade
            builder.RegisterType<FacadeApp>().As<IFacadeApp>();
            builder.RegisterType<WordFacade>().As<IWordFacade>();



            return builder.Build();
        }
    }
}
