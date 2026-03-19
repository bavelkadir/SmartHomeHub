using SmartHomeHub.Commands;
using SmartHomeHub.Core;
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

            // Här skapar vi observatörer, en för att visa statusen på en instrumentpanel och en för att logga händelser i en audit-logg
            DashboardObserver dashboard = new DashboardObserver();
            AuditObserver audit = new AuditObserver();
            LoggerObserver logger = new LoggerObserver();

            // Här lägger vi till observatörerna till lampan så att de kan få uppdateringar när lampan ändrar status
            livingRoomLamp.AddObserver(dashboard);
            livingRoomLamp.AddObserver(audit);
            livingRoomLamp.AddObserver(logger);


            // koden nedan simulerar att lampan tänds och släcks, vilket kommer att trigga uppdateringar till både instrumentpanelen och audit-loggen
            livingRoomLamp.TurnOn();
            livingRoomLamp.TurnOff();


           ////// Lamp lamp = new Lamp("Test Lamp");

           //// var turnOn = new TurnOnCommand(lamp);
           //// var turnOff = new TurnOffCommand(lamp);

           // turnOn.Execute();
           // turnOff.Execute();


            Lamp lamp = new Lamp("Living Room Lamp");

            CommandInvoker invoker = new CommandInvoker();

            invoker.AddCommand(new TurnOnCommand(lamp));
            invoker.AddCommand(new TurnOffCommand(lamp));
            invoker.AddCommand(new TurnOnCommand(lamp));

            invoker.ExecuteCommands();

            Console.WriteLine("\n--- REPLAY ---\n");

            invoker.ReplayLastCommands();











        }
    }
}
