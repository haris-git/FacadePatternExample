using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.HomeTheaterDevices
{
    public class PopcornPopper
    {
        public bool PopcornPopperTurnedOn { get; private set; }

        public PopcornPopper()
        {
            PopcornPopperTurnedOn = false;
        }

        public void On()
        {
            PopcornPopperTurnedOn = true;
            Console.WriteLine("PopcornPopper is turned on!\n");
        }

        public void Off()
        {
            PopcornPopperTurnedOn = false;
            Console.WriteLine("PopcornPopper is turned off!\n");
        }

        public void Pop()
        {
            Console.WriteLine("PopcornPopper has started popping the pop corn!\n");
        }
    }
}
