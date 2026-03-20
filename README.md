SmartHomeHub/
├── Commands/
│   ├── ICommand.cs
│   ├── TurnOnCommand.cs
│   ├── TurnOffCommand.cs
│   └── SetTemperatureCommand.cs
├── Core/
│   ├── AppLogger.cs
│   ├── CommandInvoker.cs
│   └── SmartHomeFacade.cs
├── Devices/
│   ├── IDevice.cs
│   ├── Lamp.cs
│   ├── Thermostat.cs
│   └── DoorLock.cs
├── Observer/
│   ├── IObserver.cs
│   ├── DashboardObserver.cs
│   ├── LoggerObserver.cs
│   └── AuditObserver.cs
├── Strategy/
│   ├── IModeStrategy.cs
│   ├── NormalModeStrategy.cs
│   ├── EcoModeStrategy.cs
│   └── PartyModeStrategy.cs
└── Program.cs
