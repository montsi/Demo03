using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasherApplication
{
    class Washer
    {
        // ominaisuudet
        public bool IsOn { get; set; }
        public string Program { get; set; }
        public int WaterTemp { get; set; }
        public int ProgramLenght { get; set; }

        // metodi pesukoneen käynnistykseen
        public void WasherStart()
        {
            Console.WriteLine("*hummm*");
        }

        // metodi ohjelman päättymiseen
        public void WasherDone()
        {
            Console.WriteLine("*lorinaa*");
        }
    }
}
