using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    

    class InsertCodeHere
    {
        
        public void MyCode()
        {
            List<Car> carsList = new List<Car>();

            Car c1 = new Car("CJ 32 802", 200);
            Car c2 = new Car("ZX 38 005", 100);
            Car c3 = new Car("XJ 20 013", 300);
            carsList.Add(c1);
            carsList.Add(c2);
            carsList.Add(c3);

            string licensePlate = "CJ 32 802";
            int priceSearch = 100;
            
            


            Predicate<Car> carMatchFunc = (Car c) => { return c.Price == priceSearch; };
            Car matchCar = carsList.Find(carMatchFunc);
            if (matchCar != null)
            {
                Console.WriteLine($"Car with price {priceSearch} does exist");
            }
            else
                Console.WriteLine($"Car with price {priceSearch} does not exist!");

            carMatchFunc = (Car c) => { return c.LicensePlate == licensePlate; };

            Car matchCarLicense = carsList.Find(carMatchFunc);

            if (matchCarLicense != null)
            {
                Console.WriteLine($"Car with {licensePlate} does exist");
            }
            else
                Console.WriteLine($"Car with licenseplate {licensePlate} does not exist!");

        }

    }
}
