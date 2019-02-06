using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
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

            Car theCar = null;
            //theCar = FindCar(carsList, Condition matchCondition)

            if (theCar != null)
            {
                Console.WriteLine($"Car with {licensePlate} does exist");
            }
            else
                Console.WriteLine($"Car with licenseplate {licensePlate} does not exist!");

        }


        // Need different set of parameters
        //private Car FindCar(List<Car> carsList, Condition matchCondition)
        //{
        //    Car theCar = null;
        //    foreach (Car aCar in carsList)
        //    {
        //        if (matchCondition(aCar, ...))
        //        {
        //            theCar = aCar;
        //        }
        //    }

        //    return theCar;
        //}

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
