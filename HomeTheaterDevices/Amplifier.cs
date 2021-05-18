using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.HomeTheaterDevices
{
    public class Amplifier
    {
        public Tuner Tuner { get; set; }
        public DvdPlayer DvdPlayer { get; set; }
        public CdPlayer CdPlayer { get; set; }
        public bool AmplifierTurnedOn { get; private set; }

        public Amplifier()
        {
            AmplifierTurnedOn = false;
        }

        public Amplifier(Tuner tuner, DvdPlayer dvdPlayer, CdPlayer cdPlayer)
        {
            this.Tuner = tuner;
            this.DvdPlayer = dvdPlayer;
            this.CdPlayer = cdPlayer;
            AmplifierTurnedOn = false;
        }

        public void On()
        {
            AmplifierTurnedOn = true;
            Console.WriteLine("Amplifier is turned on!\n");
        }

        public void Off()
        {
            AmplifierTurnedOn = false;
            Console.WriteLine("Amplifier is turned off!\n");
        }

        public void SetCd()
        {
            Console.WriteLine("Amplifier is setted to cd!\n");
        }

        public void SetDvd()
        {
            Console.WriteLine("Amplifier is setted to dvd!\n");
        }

        public void SetStereoSound()
        {
            Console.WriteLine("Amplifier's sound is setted to stereo!\n");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Amplifier's sound is setted to surround!\n");
        }

        public void SetTuner()
        {
            Console.WriteLine("Amplifier is setted to tuner!\n");
        }

        public void SetVolume(int value)
        {
            Console.WriteLine($"The volume of the amplifier is setted to {value}!\n");
        }
    }
}
