using Assignment2.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory.Models
{
    internal class DogFactory : IFactory
    {
        public IAnimal CreateAnimal()
        {
            return new Dog();
        }
    }
}
