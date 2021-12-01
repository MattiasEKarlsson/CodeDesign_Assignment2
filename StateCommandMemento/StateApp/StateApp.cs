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
            DisplayCommand command;
            Machine machine = new Machine();

            


            while (true)
            {
                Console.WriteLine("[S] To start/stopp machine.");
                Console.WriteLine("[C] To Enter a Command.");
                Console.WriteLine("[Q] To Clear all Commands.");
                Console.WriteLine("[Space] To Exit.");

                var userinput = Console.ReadKey().Key;
                switch (userinput)
                {
                    case ConsoleKey.S:
                        Console.Clear();
                        machine.PowerSwitch();
                        
                        break;
                    case ConsoleKey.C:
                        Console.Clear();
                        commands.Add(command = new(display, GetUserCommand()));
                        if (!GetMachineState(machine))
                        {
                            Console.WriteLine("Command will be exectuted when machine is started.");
                        }
                        break;
                    case ConsoleKey.Q:
                        
                        Console.WriteLine("Command deleted.");
                        break;

                    case ConsoleKey.Spacebar:
                        Console.Clear();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("I dont know what you mean");
                        break;
                }
                
                if (GetMachineState(machine))
                {
                    foreach (var item in commands)
                    {
                        item.Do();
                    }
                    commands.Clear();
                }
            }
        }

        string GetUserCommand()
        {
            Console.Clear();
            Console.WriteLine("Enter command:");
            string input = Console.ReadLine();
            Console.Clear();
            return input;
            

        }
        bool GetMachineState(Machine machine)
        {
            if (machine.MachineState.GetType().Name.ToString() == "MachineOnState")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
