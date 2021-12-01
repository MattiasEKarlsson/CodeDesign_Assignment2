using Assignment2.AbstractFactory;
using Assignment2.Adapter;
using Assignment2.Adapter.AdapterApp;
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

        public Application(IAbstractFactoryApp abstractFactory, IAdapterApp adapter)
        {
            AbstractFactory = abstractFactory;
            Adapter = adapter;
        }

        public void Run()
        {
            
            //AbstractFactory.Run();
            Adapter.Run();
            
        }
    }
}
