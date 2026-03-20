using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeHub.Strategy
{
    public class EcoModeStrategy : IModeStrategy
    {

        // koden nedan visa EcoMode strategin, där alla åtgärder är tillåtna och vi skriver ut ett meddelande om det när ApplyMode-metoden anropas
        public void ApplyMode(string deviceName, string action)
        {
            if (action == "TurnOn")
            {
                Console.WriteLine($"[EcoMode] {deviceName} is not allowed to turn on to save energy.");
            }
            else
            {
                Console.WriteLine($"[EcoMode] {deviceName} allowed: {action}");
            }


        }
    }

}