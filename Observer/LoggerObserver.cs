using System;
using System.Collections.Generic;
using System.Text;
using SmartHomeHub.Core;
namespace SmartHomeHub.Observer
{   
    // koden nedan skapar en klass som implementerar IObserver-gränssnittet, så att den kan registreras som en observatör på enheter i smarta hemmet och få uppdateringar när de ändrar status, så att den kan logga dessa uppdateringar med hjälp av AppLogger-klassen
    public class LoggerObserver : IObserver
    {   
        // koden nedan implementerar Update-metoden från IObserver-gränssnittet, så att den kan ta emot uppdateringar från enheter i smarta hemmet och logga dem med hjälp av AppLogger-klassen, så att vi kan hålla reda på vad som händer i appen och felsöka eventuella problem
        public void Update(string deviceName, string message)
        {
            AppLogger.Instance.Log($"{deviceName}: {message}");
        }
    }
}
