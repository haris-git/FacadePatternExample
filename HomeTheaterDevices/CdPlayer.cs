using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.HomeTheaterDevices
{
    public class CdPlayer
    {
        public Amplifier Amplifier { get; private set; }
        public bool CdPlayerTurnedOn { get; private set; }

        public CdPlayer(Amplifier amplifier)
        {
            this.Amplifier = amplifier;
            amplifier.CdPlayer = this;
            CdPlayerTurnedOn = false;
        }

        public void On()
        {
            CdPlayerTurnedOn = true;
            Console.WriteLine("CdPlayer is turned on!\n");
        }

        public void Off()
        {
            CdPlayerTurnedOn = false;
            Console.WriteLine("CdPlayer is turned off!\n");
        }

        public void Eject()
        {
            Console.WriteLine("Cd is ejected from CdPlayer!\n");
        }

        public void Pause()
        {
            Console.WriteLine("CdPlayer is paused!\n");
        }

        public void Play()
        {
            Console.WriteLine("CdPlayer is playing the cd!\n");
        }

        public void Stop()
        {
            Console.WriteLine("CdPlayer has stopped playing the cd!\n");
        }
    }
}
