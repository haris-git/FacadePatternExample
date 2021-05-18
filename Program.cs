using FacadePattern.FacadePatternClasses;
using FacadePattern.HomeTheaterDevices;
using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PopcornPopper popper = new PopcornPopper();
            Amplifier amplifier = new Amplifier();
            CdPlayer cdPlayer = new CdPlayer(amplifier);
            DvdPlayer dvdPlayer = new DvdPlayer(amplifier);
            Projector projector = new Projector(dvdPlayer);
            Screen screen = new Screen();
            TheaterLights theaterLights = new TheaterLights();
            Tuner tuner = new Tuner(amplifier);

            #region The procedure to watch a movie, without the facade pattern object.
            //popper.On();
            //popper.Pop();
            //theaterLights.On();
            //theaterLights.Dim(50);
            //screen.Down();
            //projector.On();
            //projector.WideScreenMode();
            //amplifier.On();
            //amplifier.SetDvd();
            //amplifier.SetSurroundSound();
            //amplifier.SetVolume(5);
            //dvdPlayer.On();
            //dvdPlayer.Play();

            // Add more code below, in order to stop watching the movie...
            // ..............
            // ..............
            // ..............
            // ..............
            #endregion

            #region The procedure to watch a movie, with the facade pattern object.
            HomeTheaterFacade homeTheaterFacade = new HomeTheaterFacade(popper, amplifier, cdPlayer, dvdPlayer, projector, screen, theaterLights, tuner);

            homeTheaterFacade.WatchMovie();
            homeTheaterFacade.EndMovie();
            #endregion
        }
    }
}
