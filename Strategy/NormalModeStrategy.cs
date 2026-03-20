using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeHub.Strategy
{
    public class NormalModeStrategy : IModeStrategy
    {
        // koden nedan visa normal mode strategin, där alla åtgärder är tillåtna och vi skriver ut ett meddelande om det när ApplyMode-metoden anropas
        public void ApplyMode(string deviceName, string action)
        {

            Console.WriteLine($"[NormalMode] {deviceName} allowed: {action}");
         
        
        }


    }
}
