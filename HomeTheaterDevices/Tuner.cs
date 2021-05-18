using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.HomeTheaterDevices
{
    public class Tuner
    {
        public Amplifier Amplifier { get; private set; }
        public bool TunerTurnedOn { get; private set; }

        public Tuner(Amplifier amplifier)
        {
            this.Amplifier = amplifier;
            amplifier.Tuner = this;
            TunerTurnedOn = false;
        }

        public void On()
        {
            TunerTurnedOn = true;
            Console.WriteLine("The tuner is turned on!\n");
        }

        public void Off()
        {
            TunerTurnedOn = false;
            Console.WriteLine("The tuner is turned off!\n");
        }

        public void SetAm()
        {
            Console.WriteLine("The tuner is set to AM!\n");
        }

        public void SetFm()
        {
            Console.WriteLine("The tuner is set to FM!\n");
        }

        public void SetFrequency()
        {
            Console.WriteLine("The frequency of the tuner has changed!\n");
        }
    }
}
