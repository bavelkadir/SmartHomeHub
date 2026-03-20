using SmartHomeHub.Commands;
using SmartHomeHub.Core;
using SmartHomeHub.Devices;
using SmartHomeHub.Observer;
using SmartHomeHub.Strategy;


namespace SmartHomeHub
{

    internal class Program
    {
        static void Main(string[] args)
        {
            SmartHomeFacade hub = new SmartHomeFacade();

            Lamp lamp = new Lamp("Living Room Lamp");

            hub.AddDevice(lamp);

            hub.AddObserverToDevice("Living Room Lamp", new DashboardObserver());
            hub.AddObserverToDevice("Living Room Lamp", new AuditObserver());
            hub.AddObserverToDevice("Living Room Lamp", new LoggerObserver());

            Console.WriteLine("\n--- NORMAL MODE ---\n");
            hub.SetMode(new NormalModeStrategy());
            hub.RunCommand(new TurnOnCommand(lamp));
            hub.RunCommand(new TurnOffCommand(lamp));
            hub.ExecuteCommands();

            Console.WriteLine("\n--- ECO MODE ---\n");
            hub.SetMode(new EcoModeStrategy());
            hub.RunCommand(new TurnOnCommand(lamp));
            hub.RunCommand(new TurnOffCommand(lamp));
            hub.ExecuteCommands();

            Console.WriteLine("\n--- PARTY MODE ---\n");
            hub.SetMode(new PartyModeStrategy());
            hub.RunCommand(new TurnOnCommand(lamp));
            hub.ExecuteCommands();

            Console.WriteLine("\n--- REPLAY ---\n");
            hub.Replay();

            Console.WriteLine("\n--- MORNING ROUTINE ---\n");
            hub.MorningRoutine();
        }
    }
}