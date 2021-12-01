using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Commands
{
    public class Display : IDisplay
    {
        void IDisplay.Display(string message)
        {
            Console.WriteLine(message);
        }
    }
}
