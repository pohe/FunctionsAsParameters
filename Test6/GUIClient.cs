using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6
{
    public class GUIClient
    {
        // Rest of class omitted for brevity

        public void TemperatureHasChanged(double temperature)
        {
            Console.WriteLine("Current temperature GUI1 : " + temperature);
        }
    }

}
