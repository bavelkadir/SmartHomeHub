using System;
using System.Collections.Generic;

namespace SmartHomeHub.Devices
{
    public class Thermostat : IDevice
    {

        public string Name { get; }
        private double temperature;

        private bool isOn;

        public Thermostat(string name)
        {
            Name = name;
        }

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine($"{Name} is on");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine($"{Name} is off");
        }

        public void SetTemperature(double temp)
        {
            temperature = temp;
            Console.WriteLine($"{Name} set to {temperature}°C");
        }


    }
}
