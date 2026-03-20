using System;
using System.Collections.Generic;
using System.Text;
using System;


namespace SmartHomeHub.Strategy
{    

    // koden nedan visar en strategi för "PartyMode", där alla åtgärder är tillåtna 
    public class PartyModeStrategy : IModeStrategy
    {
        public void ApplyMode(string deviceName, string action)
        {
            Console.WriteLine($"[PartyMode] EVERYTHING ALLOWED {deviceName}: {action}");
        }
    }
}