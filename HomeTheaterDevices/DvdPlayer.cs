using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.HomeTheaterDevices
{
    public class DvdPlayer
    {
        public Amplifier Amplifier { get; private set; }
        public bool DvdPlayerTurnedOn { get; private set; }

        public DvdPlayer(Amplifier amplifier)
        {
            this.Amplifier = amplifier;
            amplifier.DvdPlayer = this;
            DvdPlayerTurnedOn = false;
        }

        public void On()
        {
            DvdPlayerTurnedOn = true;
            Console.WriteLine("DvdPlayer is turned on!\n");
        }

        public void Off()
        {
            DvdPlayerTurnedOn = false;
            Console.WriteLine("DvdPlayer is turned off!\n");
        }

        public void Eject()
        {
            Console.WriteLine("Dvd is ejected from DvdPlayer!\n");
        }

        public void Pause()
        {
            Console.WriteLine("DvdPlayer is paused!\n");
        }

        public void Play()
        {
            Console.WriteLine("DvdPlayer is playing the Dvd!\n");
        }

        public void Stop()
        {
            Console.WriteLine("DvdPlayer has stopped playing the Dvd!\n");
        }
    }
}
