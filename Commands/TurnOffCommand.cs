using System;
using System.Collections.Generic;
using System.Text;

using SmartHomeHub.Devices;

namespace SmartHomeHub.Commands
{
    // samma som i turn on klassen fast nu kör vi off istället för on
    public class TurnOffCommand : ICommand
    {
        private IDevice device;

        public TurnOffCommand(IDevice device)
        {
            this.device = device;
        }

        public void Execute()
        {
            device.TurnOff();
        }
    }
}