using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.MachineState
{
    public class MachineMemento
    {
        public Machine Machine { get; set; }
        public IMachineState MachineState { get; set; }

        public MachineMemento(Machine machine, IMachineState machineState)
        {
            Machine = machine;
            MachineState = machineState;
        }

        public void Restore()
        {
            Machine.MachineState = MachineState;
            Console.WriteLine("*******************");
            Console.WriteLine("Machine Power OFF");
            Console.WriteLine("All commands DELETED.");
            Console.WriteLine("*******************");
        }

    }
}
