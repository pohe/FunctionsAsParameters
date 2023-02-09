using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    class InsertCodeHere
    {
        delegate bool CarCheckDelegate(Car c);
        private CarCheckDelegate theCarCheckDelegate = null;

        

        public void MyCode()
        {

            List<Car> carsList = new List<Car>();

            Car c1 = new Car("CJ 32 802", 100);
            Car c2 = new Car("ZX 38 005", 100);
            Car c3 = new Car("XJ 20 013", 300);
            carsList.Add(c1);
            carsList.Add(c2);
            carsList.Add(c3);

            string licensePlate = "CJ 32 802";
            int priceSearch = 100;

            theCarCheckDelegate += (c) => c.LicensePlate == licensePlate;
            theCarCheckDelegate += c => c.Price == priceSearch;

            bool result = theCarCheckDelegate(c1);

            if (result)
            {
                Console.WriteLine($"Car with {licensePlate} and price 100 does exist");
            }
            else
                Console.WriteLine($"Car with licenseplate {licensePlate}  and price 100 does not exist!");


            Car c4 = new Car("CJ 32 802", 100);
            carsList.Add(c4);
            Predicate<Car> theCarCheckDelegate2 = null;
            theCarCheckDelegate2 += c => c.Price == priceSearch;
            //theCarCheckDelegate2 += c => c.LicensePlate == licensePlate;
            List<Car> resultList = carsList.FindAll(theCarCheckDelegate2);
            Console.WriteLine($"Number of cars fullfilling both recuirements is {resultList.Count}");


        }
    }
}
