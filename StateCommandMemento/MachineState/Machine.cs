using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.MachineState
{
    public class Machine : IMachineState
    {
        public IMachineState MachineState { get; set; }
        public Machine()
        {
            MachineState = new MachineOffState();
        }


        public void PowerSwitch()
        {
            MachineState.PowerSwitch();
            if (MachineState is MachineOffState)
            {
                MachineState = new MachineOnState();
            }
            else
            {
                MachineState = new MachineOffState();
            }
        }
        public MachineMemento CreateMemento()
        {
            return new MachineMemento(this, MachineState);
        }
    }
}
