using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasherApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // luodaan washer-olio eli Washer luokan instanssi ja annetaan arvoja
            Washer washer = new Washer(); 
            washer.IsOn = true;
            washer.Program = "Quickwash";
            washer.WaterTemp = 40;
            washer.ProgramLenght = 30;
            washer.WasherStart();   // koneen käynnistys
            Console.WriteLine("Program is: " + washer.Program);
            Console.WriteLine("Water temperature is: " + washer.WaterTemp + " C");
            Console.WriteLine("Program lenght is: " + washer.ProgramLenght + " min");
            Console.WriteLine("...Waiting for " + washer.ProgramLenght + " minutes...");
            washer.WasherDone();    // ohjelma valmis

            Console.ReadLine();
        }
    }
}
