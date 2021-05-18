using FacadePattern.HomeTheaterDevices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.FacadePatternClasses
{
    public class HomeTheaterFacade
    {
        public PopcornPopper Popper { get; private set; }
        public Amplifier Amplifier { get; private set; }
        public CdPlayer CdPlayer { get; private set; }
        public DvdPlayer DvdPlayer { get; private set; }
        public Projector Projector { get; private set; }
        public Screen Screen { get; private set; }
        public TheaterLights TheaterLights { get; private set; }
        public Tuner Tuner { get; private set; }


        public HomeTheaterFacade(PopcornPopper popper, Amplifier amplifier, CdPlayer cdPlayer, DvdPlayer dvdPlayer, Projector projector, Screen screen, TheaterLights theaterLights, Tuner tuner)
        {
            Popper = popper;
            Amplifier = amplifier;
            CdPlayer = cdPlayer;
            DvdPlayer = dvdPlayer;
            Projector = projector;
            Screen = screen;
            TheaterLights = theaterLights;
            Tuner = tuner;
        }

        public void WatchMovie()
        {
            Console.WriteLine("\n\n#######################################");
            Console.WriteLine("#######################################");
            Console.WriteLine("## You are going to watch a movie... ##");
            Console.WriteLine("#######################################");
            Console.WriteLine("#######################################\n\n");
            Popper.On();
            Popper.Pop();
            TheaterLights.On();
            TheaterLights.Dim(50);
            Screen.Down();
            Projector.On();
            Projector.WideScreenMode();
            Amplifier.On();
            Amplifier.SetDvd();
            Amplifier.SetSurroundSound();
            Amplifier.SetVolume(5);
            DvdPlayer.On();
            DvdPlayer.Play();
        }

        public void EndMovie()
        {
            Console.WriteLine("\n\n##############################################################");
            Console.WriteLine("##############################################################");
            Console.WriteLine("## Stopping the movie and shutting down the home theater... ##");
            Console.WriteLine("##############################################################");
            Console.WriteLine("##############################################################\n\n");

            Popper.Off();
            TheaterLights.Off();
            Screen.Up();
            Projector.Off();
            Amplifier.Off();
            DvdPlayer.Stop();
            DvdPlayer.Eject();
            DvdPlayer.Off();
        }

        public void ListenToCd()
        {
            Console.WriteLine("\n\nYou are going to listen to an audio cd...\n\n");
            // some code here...
        }

        public void EndCd()
        {
            Console.WriteLine("\n\nStopping the audio cd and shutting down the cd player...\n\n");
            // some code here...
        }

        public void ListenToRadio()
        {
            Console.WriteLine("\n\nYou are going to listen to the radio...\n\n");
            // some code here...
        }

        public void EndRadio()
        {
            Console.WriteLine("\n\nShutting down the radio...\n\n");
            // some code here...
        }
    }
}
