using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVApplication
{
    class TV
    {
        // ominaisuudet
        public string ScreenType { get; set; }
        public double Weight { get; set; }
        public int ScreenSize { get; set; }
        public int DefaultCh { get; set; }
        

        // metodit: TV:n käynnistys...
        public void turnOn()
        {
            Console.WriteLine("*TV is on*");
        }

        // ...kanavan vaihdot...
        public void changeChUp()
        {
            DefaultCh++;
        }
        public void changeChDown()
        {
            DefaultCh--;
        }

        // ...ja TV:n sammutus
        public void turnOff()
        {
            Console.WriteLine("*TV is off*");
        }
    }
}
