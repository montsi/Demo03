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
            Washer washer = new Washer();
            washer.IsOn = true;
            washer.Program = "pikapesu";
            washer.WaterTemp = 40;
            washer.ProgramLenght = 30;
            washer.WasherStart();
            Console.WriteLine("Program is:" + washer.Program);
            Console.WriteLine("Water temperature is:" + washer.WaterTemp);
            Console.WriteLine("Program lenght is:" + washer.ProgramLenght);

            Console.ReadLine();
        }
    }
}
