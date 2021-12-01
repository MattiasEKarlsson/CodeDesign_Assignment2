using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Commands
{
    public class DisplayCommand : ICommand
    {
        public IDisplay Display { get; set; }
        public string DisplayMessage { get; set; }
        public DisplayCommand(IDisplay display, string displayMessage)
        {
            Display = display;
            DisplayMessage = displayMessage;
        }

        public void Do()
        {
            Console.WriteLine($"Displaying:");
            Display.Display(DisplayMessage);
        }
    }
}
