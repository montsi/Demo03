using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // luodaan vehicle-olio eli Vehicle luokan instanssi ja annetaan arvoja
            Vehicle vehicle = new Vehicle();
            vehicle.Name = "minibus";
            vehicle.Speed = 80;
            vehicle.Tyres = 4;

            // toiminnot tulostukseen
            vehicle.PrintData();
            vehicle.ToString();

            Console.ReadLine();
        }
    }
}
