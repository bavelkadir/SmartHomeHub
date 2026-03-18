using SmartHomeHub.Devices;
using SmartHomeHub.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeHub.Devices
{
    public class Lamp : IDevice
    {
        public string Name { get; private set; }

      
        // lägger till en boolean variabel för att hålla reda på om lampan är på eller av
        private bool isOn;
        // lägger till en lista för att hålla reda på alla observatörer som är registrerade på lampan
        private List<IObserver> observers = new List<IObserver>();

        public Lamp(string name)
        {
            Name = name;
        }
        
        // skapar en metod för att lägga till observatörer till lampan, så att de kan få uppdateringar när lampan ändrar status
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
            Console.WriteLine("Observer added!");
        }

        // koden nedan skapar en metod där lampan kan skicka uppdateringar till alla registrerade observatörer när den ändrar status, så att de kan reagera på det
        private void NotifyObservers(string message)
        {
            Console.WriteLine("NotifyObservers is running...");

            foreach (var observer in observers)
            {
                observer.Update(Name, message);
            }
        }


        // Implementerar metoderna från IDevice-gränssnittet
        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine($"{Name} is ON");
            NotifyObservers("Turned ON");
        }

        
        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine($"{Name} is OFF");
            NotifyObservers("Turned OFF");
        }
    }
}