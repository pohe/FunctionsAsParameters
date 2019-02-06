using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();

            GUIClient client = new GUIClient();
            GUIClient2 client2 = new GUIClient2();

            monitor.TemperatureChanged += client.TemperatureHasChanged;
            monitor.TemperatureChanged += client2.Temperature2Changed;
            for (int i = 0; i < 10; i++)
            {
                monitor.MonitorDevice();
            }
            Console.ReadKey();
        }
    }
}
