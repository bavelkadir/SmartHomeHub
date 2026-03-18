using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeHub.Observer
{
    public class DashboardObserver : IObserver
    {
        // Implementerar Update-metoden från IObserver-gränssnittet
        public void Update(string deviceName, string message)
        {
            Console.WriteLine($"[Dashboard] {deviceName}: {message}");
        }

    }
}
