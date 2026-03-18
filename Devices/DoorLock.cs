using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeHub.Devices
{
    public class DoorLock : IDevice
    {

        public string Name { get; private set; }

        private bool isLocked;

        public DoorLock(string name)
        {
            Name = name;
        }


        public void TurnOn()
        {
            Lock();

        }

        public void TurnOff()
        {

            Unlock();

        }

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
    