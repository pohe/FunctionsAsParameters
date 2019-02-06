using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> carsDict = new Dictionary<string, Car>();

            Car c1 = new Car("CJ 32 802");
            Car c2 = new Car("ZX 38 005");
            Car c3 = new Car("XJ 20 013");
            carsDict.Add(c1.LicensePlate, c1);
            carsDict.Add(c2.LicensePlate, c2);
            carsDict.Add(c3.LicensePlate, c3);

            string licensePlate = "CJ 32 802";

            if (carsDict.ContainsKey(licensePlate))
            {
                Console.WriteLine($"Car with {carsDict[licensePlate]} does exist");
            }
            else
                Console.WriteLine($"Car with licenseplate {licensePlate} does not exist!");
            Console.ReadKey();
        }
    }
}
