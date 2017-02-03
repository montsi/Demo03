using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Vehicle
    {
        // ominaisuudet
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        // metodit tietojen tulostukseen
        public void PrintData()
        {
            Console.WriteLine("vehicle name: " + Name);
            Console.WriteLine("vehicle speed: " + Speed);
            Console.WriteLine("vehicle has " + Tyres + " tyres");
        }

        public void ToString()
        {
            Console.Write("Vehicle name: " + Name + ", Vehicle speed: " + Speed + ", Vehicle has " + Tyres + " tyres.");          
        }
    }
}
