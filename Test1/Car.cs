using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Car
    {
        private string _licensePlate;

        public string LicensePlate { get { return _licensePlate; } }

        // Rest of class definition omitted

        public Car(string licensePlate)
        {
            _licensePlate = licensePlate;
        }

        public override string ToString()
        {
            return $"Car with licenseplate {_licensePlate}";
        }
    }

}
