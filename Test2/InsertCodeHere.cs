using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            List<Car> carsList = new List<Car>();

            Car c1 = new Car("CJ 32 802",200);
            Car c2 = new Car("ZX 38 005", 100);
            Car c3 = new Car("XJ 20 013", 300);
            carsList.Add(c1);
            carsList.Add(c2);
            carsList.Add(c3);

            string licensePlate = "CJ 32 802";
            int priceSearch = 100; 

            Car theCar = null;
            foreach (Car aCar in carsList)
            {
                // This is the part that differs if we want to use another criterium
                if (aCar.LicensePlate == licensePlate)
                //if (aCar.Price == priceSearch)
                //if (LicensePlateMatch(aCar, licensePlate))
                //if (PriceMatch( aCar, priceSearch))
                {
                    theCar = aCar;
                }
            }
            //Alternative implementation
            //string result = theCar != null? $"Car with {licensePlate} does exist": $"Car with licenseplate {licensePlate} does not exist!";
            //Console.WriteLine(result);
            if (theCar != null)
            {
                Console.WriteLine($"Car with {licensePlate} does exist");
            }
            else
                Console.WriteLine($"Car with licenseplate {licensePlate} does not exist!");
            //if (theCar != null)
            //{
            //    Console.WriteLine($"Car with {priceSearch} does exist");
            //}
            //else
            //    Console.WriteLine($"Car with price {priceSearch} does not exist!");


        }

        private bool LicensePlateMatch(Car aCar, string licensePlate)
        {
            return aCar.LicensePlate == licensePlate;
        }
        private bool PriceMatch(Car aCar, int price)
        {
            return aCar.Price == price;
        }
    }
}
