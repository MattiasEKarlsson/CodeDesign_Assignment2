using Assignment2.AbstractFactory;
using Assignment2.Adapter;
using Assignment2.Adapter.AdapterApp;
using Assignment2.Facade.FacadeApp;
using Assignment2.StateCommandMemento.StateApp;
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
        IStateApp StateApp;

        public Application(IAbstractFactoryApp abstractFactory, IAdapterApp adapter, IFacadeApp facadeApp, IStateApp stateApp)
        {
            AbstractFactory = abstractFactory;
            Adapter = adapter;
            Facade = facadeApp;
            StateApp = stateApp;
        }

        public void Run()
        {
            //AbstractFactory.Run();
            //Adapter.Run();
            //Facade.Run();
            StateApp.Run();
        }
    }
}
