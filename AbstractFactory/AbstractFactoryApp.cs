
using Assignment2.AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    public class AbstractFactoryApp : IAbstractFactoryApp
    {
        

        public void Run()
        {
            Console.WriteLine("Abstract Factory");
            var factoryFactory = new FactoryFactory();
            var animalFactoryDog = factoryFactory.GetFactory("Dog");
            var animalFactoryCat = factoryFactory.GetFactory("Cat");
            var dog = animalFactoryDog.CreateAnimal();
            var cat = animalFactoryCat.CreateAnimal();
            Console.WriteLine(dog);
            Console.WriteLine(cat);
        }
    }
}
