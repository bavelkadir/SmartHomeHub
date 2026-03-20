using System;
using System.Collections.Generic;
using System.Text;
using SmartHomeHub.Commands;
using SmartHomeHub.Devices;
using SmartHomeHub.Observer;
using SmartHomeHub.Strategy;

namespace SmartHomeHub.Core
{

    public class SmartHomeFacade
    {

        // koderna neda skapar en lista för att hålla reda på alla enheter i det smarta hemmet, en instans av CommandInvoker-klassen för att hantera kommandon, och en variabel för att hålla reda på den aktuella lägesstrategin som används i det smarta hemmet
        private List<IDevice> devices = new List<IDevice>();
        private CommandInvoker invoker = new CommandInvoker();
        private IModeStrategy currentMode;


        // koderna nedan definierar en metod för att ställa in lägesstrategin i det smarta hemmet, en metod för att lägga till en enhet till det smarta hemmet, och en metod för att lägga till en observatör till en specifik enhet i det smarta hemmet
        public void AddDevice(IDevice device)
        {
            devices.Add(device);
            Console.WriteLine($"Device {device.Name} added to Smart Home");
        }

        // koderna nedan söker efter en enhet i listan över enheter baserat på dess namn, och om den hittar en enhet med det namnet, så kontrollerar den om det är en Lamp-enhet. Om det är en Lamp-enhet, så lägger den till observatören till lampan, så att den kan få uppdateringar när lampan ändrar status. Om det inte är en Lamp-enhet, så skriver den ut ett meddelande som säger att enheten inte stöder observatörer. Om den inte hittar någon enhet med det namnet, så skriver den ut ett meddelande som säger att enheten inte hittades
        public void AddObserverToDevice(string deviceName, IObserver observer)
        {

            var device = devices.Find(d => d.Name == deviceName);
            if (device != null)
            {
                if (device is Lamp lamp)
                {
                    lamp.AddObserver(observer);
                    Console.WriteLine($"Observer added to {deviceName}");
                }
                else
                {
                    Console.WriteLine($"Device {deviceName} does not support observers");
                }
            }
            else
            {
                Console.WriteLine($"Device {deviceName} not found");
            }
        }

        // koderna nedan definierar en metod för att ställa in lägesstrategin i det smarta hemmet. Denna metod tar en IModeStrategy-objekt som parameter och tilldelar det till currentMode-variabeln. Sedan itererar den genom alla enheter i listan över enheter, och om enheten är en Lamp-enhet, så anropar den SetMode-metoden på lampan och skickar in den nya lägesstrategin. Detta gör att alla lampor i det smarta hemmet uppdateras med den nya lägesstrategin när den ändras
        public void SetMode(IModeStrategy mode)
        {
            currentMode = mode;

            foreach (var device in devices)
            {
                if (device is Lamp lamp)
                {
                    lamp.SetMode(mode);
                }
            }
        }

        // koderna nedan definierar en metod för att köra ett kommando i det smarta hemmet. Denna metod tar ett ICommand-objekt som parameter och anropar AddCommand-metoden på invoker-objektet för att lägga till kommandot i listan över kommandon som ska köras. Sedan definierar den en metod för att köra alla kommandon i listan över kommandon, och en metod för att spela upp de senaste kommandona igen
        public void RunCommand(ICommand command)
        {
            invoker.AddCommand(command);
        }

        public void ExecuteCommands()
        {
            invoker.ExecuteCommands();
        }

        public void Replay()
        {
            invoker.ReplayLastCommands();
        }

        //koderna nedan definierar en metod för att köra en morgonrutin i det smarta hemmet. Denna metod itererar genom alla enheter i listan över enheter, och för varje enhet så skapar den ett TurnOnCommand-objekt och lägger till det i listan över kommandon som ska köras. Sedan anropar den ExecuteCommands-metoden för att köra alla kommandon i listan, vilket resulterar i att alla enheter i det smarta hemmet slås på när morgonrutinen körs
        public void MorningRoutine()
        {
            foreach (var device in devices)
            {
                invoker.AddCommand(new TurnOnCommand(device));
            }

            invoker.ExecuteCommands();



        }

    }
}