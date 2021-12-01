using Assignment2.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory.Models
{
    internal class FactoryFactory
    {
        public FactoryFactory()
        {
        }

        internal IFactory GetFactory(string typeOfFactory)
        {
            if (typeOfFactory == "Dog")
            {
                return new DogFactory();
            }
            if (typeOfFactory == "Cat")
            {
                return new CatFactory();
            }
            return null;
        }
    }
}
