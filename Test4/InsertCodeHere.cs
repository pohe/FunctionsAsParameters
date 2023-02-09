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

            string licensePlate = "XJ 20 013";
            int priceSearch = 100;

            Predicate<Car> carMatchFunc = (Car c) => { return c.Price == priceSearch; };

            // Predicate < Car > carMatchFunc = (Car c) => { return c.Price == priceSearch; };
            //Predicate<Car> carMatchFunc = CarPriceMatch;

            carMatchFunc = (Car c) => { return c.LicensePlate == licensePlate; };

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

            //carsList.Sort(delegate (Car x, Car y) {
            //    if (x.Price < y.Price)
            //        return -1;
            //    else if (x.Price == y.Price)
            //        return 0;
            //    else return 1;
            //});

            carsList.Sort((Car x, Car y) =>
            {
                if (x.Price < y.Price)
                    return -1;
                else if (x.Price == y.Price)
                    return 0;
                else return 1;
            });

            foreach (Car car in carsList)
            {
                Console.WriteLine(car);
            }




            matchCar = carsList.Find( c  =>  c.Price == priceSearch );
            if (matchCar != null)
            {
                Console.WriteLine($"Car with {priceSearch} does exist");
            }
            else
                Console.WriteLine($"Car with price {priceSearch} does not exist!");


            matchCar = carsList.Find(c => c.LicensePlate == licensePlate);
            if (matchCar != null)
            {
                Console.WriteLine($"Car with {licensePlate} does exist");
            }
            else
                Console.WriteLine($"Car with licenseplate {licensePlate} does not exist!");




            bool CarPriceMatch(Car c)
            {
                return c.Price == priceSearch;
            }

            bool CarLicensPlateMatch(Car c)
            {
                return c.LicensePlate == licensePlate;
            }


        }

        
        

    }
}
