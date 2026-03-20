using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeHub.Strategy
{
    // fixar en kontrakt för alla strategier som implementerar IModeStrategy, där varje strategi måste implementera ApplyMode-metoden som tar emot en deviceName och en action som argument, så att de kan definiera hur de ska hantera olika åtgärder för olika enheter baserat på den aktuella strategin
    public interface IModeStrategy
    {
        void ApplyMode(string deviceName, string action);
    }
}