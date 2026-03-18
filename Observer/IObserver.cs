using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeHub.Observer
{
    // Interface för att implementera Observer-mönstret
    public interface IObserver
    {
        void Update(string deviceName, string message);
    }
}