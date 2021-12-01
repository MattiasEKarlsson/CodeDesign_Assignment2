using Assignment2.AbstractFactory;
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

        public Application(IAbstractFactoryApp abstractFactory)
        {
            AbstractFactory = abstractFactory;
        }

        public void Run()
        {
            Console.WriteLine("Abstract Factory");
            AbstractFactory.Run();
            
        }
    }
}
