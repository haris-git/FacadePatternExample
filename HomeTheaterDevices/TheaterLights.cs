using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.HomeTheaterDevices
{
    public class TheaterLights
    {
        public bool LightsTurnedOn { get; private set; }

        public TheaterLights()
        {
            LightsTurnedOn = false;
        }

        public void On()
        {
            LightsTurnedOn = true;
            Console.WriteLine("Theater lights are turned on!\n");
        }

        public void Off()
        {
            LightsTurnedOn = false;
            Console.WriteLine("Theater lights are turned off!\n");
        }

        public void Dim(int value)
        {
            Console.WriteLine($"Theater lights are dimmed to {value}%!\n");
        }
    }
}
