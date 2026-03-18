using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeHub.Devices
{
    // Interface för alla enheter i smarta hemmet
    public interface IDevice
    {
        
        string Name { get; }

        void TurnOn();
        void TurnOff();


    }
}
