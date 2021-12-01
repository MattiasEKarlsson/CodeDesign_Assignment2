using Assignment2.AbstractFactory;
using Assignment2.Adapter;
using Assignment2.Facade;
using Assignment2.StateCommandMemento;
using Autofac;
using System;

namespace Assignment2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Run Autofac Configure
            var container = AFConfig.Configure();

            // Create an instance of IApplication since we are not using a constructor here
            using var scope = container.BeginLifetimeScope();
            var app = scope.Resolve<IApplication>();
            app.Run();


            //Console.WriteLine("Abstract Factory");
            //AbstractFactoryMain abstractFactory = new();
            //abstractFactory.Run();
            //Console.WriteLine();

            //Console.WriteLine("Facade");
            //FacadeMain facadeMain = new();
            //facadeMain.Run();
            //Console.WriteLine();

            //Console.WriteLine("Adapter");
            //AdapterMain adapterMain = new();
            //adapterMain.Run();
            //Console.WriteLine();

            //Console.WriteLine("State Command Memento");
            //SCMMain scmMain = new();
            //scmMain.Run();
        }
    }
}