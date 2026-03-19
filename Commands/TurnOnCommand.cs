using System;
using System.Collections.Generic;
using System.Text;
using SmartHomeHub.Devices;
namespace SmartHomeHub.Commands
{   
    // uppfyller kontraktet i ICommand-gränssnittet och implementerar Execute()-metoden
    public class TurnOnCommand : ICommand
    {

        // skapar en privat variabel av typen IDevice, som kommer att referera till den enhet som kommandot ska utföras på
        private IDevice device;


        // skapar en konstruktor som tar emot en IDevice-objekt som parameter och tilldelar det till den privata variabeln. Detta gör att kommandot kan utföra åtgärder på den specifika enheten när Execute()-metoden anropas.
        public TurnOnCommand(IDevice device)
        {

            this.device = device;

        }
         // skapar en metod Execute() som anropar TurnOn()-metoden på den enhet som refereras av den privata variabeln. Detta gör att när Execute() anropas, kommer den specifika enheten att slås på
        public void Execute()
        {
            device.TurnOn();
        }


    }
}
