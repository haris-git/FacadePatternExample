using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.HomeTheaterDevices
{
    public class Projector
    {
        public DvdPlayer DvdPlayer { get; private set; }
        public bool ProjectorTurnedOn { get; private set; }

        public Projector(DvdPlayer dvdPlayer)
        {
            this.DvdPlayer = dvdPlayer;
            ProjectorTurnedOn = false;
        }

        public void On()
        {
            ProjectorTurnedOn = true;
            Console.WriteLine("Projector is turned on!\n");
        }

        public void Off()
        {
            ProjectorTurnedOn = false;
            Console.WriteLine("Projector is turned off!\n");
        }

        public void TvMode()
        {
            Console.WriteLine("Projector is setted to tv mode!\n");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Projector is setted to wide screen mode!\n");
        }
    }
}
