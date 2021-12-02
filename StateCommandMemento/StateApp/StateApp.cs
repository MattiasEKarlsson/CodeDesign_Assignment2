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
            MachineMemento machineMemento = machine.CreateMemento();

            while (true)
            {
                Console.WriteLine("[Space] To start/stopp machine.");
                Console.WriteLine("[C] To Enter a Command.");
                Console.WriteLine("[Q] To Clear all Commands and turn of machine.");
                Console.WriteLine("[X] To Exit.");

                var userinput = Console.ReadKey().Key;
                switch (userinput)
                {
                    case ConsoleKey.Spacebar:
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
                        Console.Clear();
                        machineMemento.Restore();
                        commands.Clear();
                        break;

                    case ConsoleKey.X:
                        Console.Clear();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid Input.");
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
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine($"Enter command");
                string userInput = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(userInput) )
                {
                    validInput = true;
                    Console.Clear();
                    return userInput;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a command.");
                }
            }
            return null;
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
