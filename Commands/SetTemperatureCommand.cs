using System;
using System.Collections.Generic;
using System.Text;
using SmartHomeHub.Devices;
namespace SmartHomeHub.Commands
{
    public class SetTemperatureCommand : ICommand
    {
        // skapar en priavte variabel av typen Thermostat, som kommer att referera till den termostat som kommandot ska utföras på
        private Thermostat thermostat;
        private double temperature;

        // skapar en konstruktor som tar emot en Thermostat-objekt och en double-variabel som parameter och tilldelar dem till de privata variablerna. Detta gör att kommandot kan utföra åtgärder på den specifika termostaten och ställa in den på den angivna temperaturen när Execute()-metoden anropas.
        public SetTemperatureCommand(Thermostat thermostat, double temperature)
        {
            this.thermostat = thermostat;
            this.temperature = temperature;
        }

        public void Execute()
        {
            thermostat.SetTemperature(temperature);
        }

    }


}