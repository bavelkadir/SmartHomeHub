using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeHub.Devices
{
    public class DoorLock : IDevice
    {

        public string Name { get; private set; }

        // lägger till en privat variabel för att hålla reda på om dörren är låst eller inte
        private bool isLocked;

        // lägger till en konstruktor som tar emot namnet på dörren
        public DoorLock(string name)
        {
            Name = name;
        }

        // lägger till en metod för att låsa dörren och en metod för att låsa upp den
        public void TurnOn()
        {
            Lock();

        }

        
        public void TurnOff()
        {

            Unlock();

        }

        // lägger till en metod för att visa statusen på dörren
        public void Lock()
        {
            isLocked = true;
            Console.WriteLine($"{Name} is locked");


        }

        
        public void Unlock()
        {
            isLocked = false;
            Console.WriteLine($"{Name} is unlocked");

 
        }
    }

}
    