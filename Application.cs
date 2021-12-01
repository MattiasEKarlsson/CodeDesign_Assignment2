using Assignment2.AbstractFactory;
using Assignment2.Adapter;
using Assignment2.Adapter.AdapterApp;
using Assignment2.Facade.FacadeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Application : IApplication
    {
        IAbstractFactoryApp AbstractFactory;
        IAdapterApp Adapter;
        IFacadeApp Facade;

        public Application(IAbstractFactoryApp abstractFactory, IAdapterApp adapter, IFacadeApp facadeApp)
        {
            AbstractFactory = abstractFactory;
            Adapter = adapter;
            Facade = facadeApp;
        }

        public void Run()
        {
            //AbstractFactory.Run();
            //Adapter.Run();
            Facade.Run();
        }
    }
}
