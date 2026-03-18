using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeHub.Devices
{
    
    public interface IDevice
    {
        
        string Name { get; }

        void TurnOn();
        void TurnOff();


    }
}
