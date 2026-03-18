using System;
using System.Collections.Generic;
using System;

namespace SmartHomeHub.Observer
{
    public class AuditObserver : IObserver
    {
        // koden nedan visualiserar att varje gång en enhet ändrar status så sparas det i en logg, i det här fallet så skriver vi ut det i konsolen
        public void Update(string deviceName, string message)
        {
            Console.WriteLine($"[Audit] Event saved for {deviceName}: {message}");
        }
    }
}