using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6
{
    public class TemperatureMonitor
    {
        //Den gravide kvinde

        private static double _temperature;

        //Action<Double>
        public event Action<double> TemperatureChanged;

        public TemperatureMonitor()
        {
            TemperatureChanged = null;
            MonitorDevice();
        }

        public void MonitorDevice()
        {
            // We assume GetTemperatureFromDevice retrieves
            // an actual temperature from some device, and
            // keeps doing so at regular intervals
            double newTemperature = GetTemperatureFromDevice();

            if (Math.Abs(newTemperature - _temperature) > 0.1)
            {
                _temperature = newTemperature;
                OnTemperatureChanged();
            }
        }

        private double GetTemperatureFromDevice()
        {
            return _temperature + 2;

        }

        private void OnTemperatureChanged()
        { //Når barnet fødes - eller ændringer sker
            TemperatureChanged?.Invoke(_temperature);
        }
    }

}
