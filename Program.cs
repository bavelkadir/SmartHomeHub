using SmartHomeHub.Devices;
using SmartHomeHub.Observer;

namespace SmartHomeHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            // Här skapar vi en instans av SmartHomeHub som kommer att hantera alla våra enheter och observatörer
            Lamp livingRoomLamp = new Lamp("Livning Room Lamp");

            // Här skapar vi två observatörer, en för att visa statusen på en instrumentpanel och en för att logga händelser i en audit-logg
            DashboardObserver dashboard = new DashboardObserver();
            AuditObserver audit = new AuditObserver();

            // Här lägger vi till observatörerna till lampan så att de kan få uppdateringar när lampan ändrar status
            livingRoomLamp.AddObserver(dashboard);
            livingRoomLamp.AddObserver(audit);

            // koden nedan simulerar att lampan tänds och släcks, vilket kommer att trigga uppdateringar till både instrumentpanelen och audit-loggen
            livingRoomLamp.TurnOn();
            livingRoomLamp.TurnOff();

            
        }
    }
}
