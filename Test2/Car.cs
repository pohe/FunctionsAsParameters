using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class Car
    {
        private string _licensePlate;

        public string LicensePlate { get { return _licensePlate; } }

        private int _price; 
        public int Price { get { return _price; }  }

        // Rest of class definition omitted

        public Car(string licensePlate, int price)
        {
            _licensePlate = licensePlate;
            _price = price; 
        }

        public override string ToString()
        {
            return $"Car with licenseplate {_licensePlate}";
        }
    }
}
