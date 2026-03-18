using System;
using System.Collections.Generic;
using System.Text;
using SmartHomeHub.Devices;

namespace SmartHomeHub.Devices
{
    public class Lamp : IDevice
    {
        public string Name { get; private set; }
        
        private bool isOn;

        public Lamp(string name)
        {
            Name = name;
        }

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine($"{Name} is ON");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine($"{Name} is OFF");
        }
    }
}