using Assignment2.StateCommandMemento.Commands;
using Assignment2.StateCommandMemento.MachineState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.StateApp
{
    public class StateApp : IStateApp
    {
        public void Run()
        {
            //List to save Commands.
            List<DisplayCommand> commands = new List<DisplayCommand>();

            Display display = new();
            DisplayCommand command = new(display, "Karlsson");
            DisplayCommand command2 = new(display, "Svenne");

            Machine machine = new Machine();
            
            
            
            while (true)
            {
                if (machine.MachineState.GetType().Name.ToString() == "MachineOffState")
                {
                    commands.Clear();
                    commands.Add(command);
                    commands.Add(command2);
                }

                var userinput = Console.ReadKey().Key;
                switch (userinput)
                {
                    case ConsoleKey.Enter:
                        machine.PowerSwitch();
                        
                        break;

                    case ConsoleKey.Spacebar:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("I dont know what you mean");
                        break;
                }
                
                if (machine.MachineState.GetType().Name.ToString() == "MachineOnState")
                {
                    foreach (var item in commands)
                    {
                        item.Do();
                    }
                }
            }
        }
    }
}
