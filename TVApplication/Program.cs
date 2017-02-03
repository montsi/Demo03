using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // luodaan tv-olio eli TV luokan instanssi ja annetaan arvoja
            TV tv = new TV();
            tv.ScreenType = "OLED";
            tv.ScreenSize = 55;
            tv.Weight = 16.5;
            tv.DefaultCh = 3;

            Console.WriteLine("Screen type is: " + tv.ScreenType);      // tulostetaan tietoja
            Console.WriteLine("Screen size is: " + tv.ScreenSize + " inches");
            Console.WriteLine("Weight of the TV is: " + tv.Weight + " kgs");
            tv.turnOn();
            tv.changeChUp();
            Console.WriteLine("Channel changed to " + tv.DefaultCh);    // tulostetaan metodien tekemiä muutoksia
            tv.changeChDown();
            Console.WriteLine("Channel changed to " + tv.DefaultCh);
            tv.turnOff();

            Console.ReadLine();
        }
    }
}
