using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace VMWareSetter
{
    public class MachineItem
    {
        public Machine machine;

        public MachineItem(Machine machine)
        {
            this.machine = machine;
        }   

        public override string ToString()
        {
            return machine.Name;
        }
    }
}
