using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.HomeTheaterDevices
{
    public class Screen
    {
        public bool ScreenDown { get; private set; }

        public Screen()
        {
            ScreenDown = false;
        }

        public void Up()
        {
            ScreenDown = false;
            Console.WriteLine("ScreenDown is up!\n");
        }

        public void Down()
        {
            ScreenDown = true;
            Console.WriteLine("ScreenDown is down!\n");
        }
    }
}
