📁 Projektstruktur
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

# Smart Home Control Center

## Beskrivning
Detta projekt är en enkel simulering av ett smart hem där man kan styra olika enheter som lampor, termostat och dörrlås. Systemet är byggt i C# som en console-applikation och använder flera designmönster för att visa hur de fungerar i praktiken.

Målet med projektet är att visa hur designmönster kan användas för att strukturera kod på ett tydligt och flexibelt sätt.

---

## Hur man kör programmet
1. Öppna projektet i Visual Studio
2. Kör programmet (Start / F5)
3. Output visas i console där olika händelser sker i systemet

---

## Designmönster

### Observer
Observer används för att uppdatera flera delar av systemet när en enhet ändrar state.  
Till exempel när en lampa tänds så får Dashboard, Audit och Logger information direkt.  
Detta gör att vi slipper hårdkoppla dessa delar till varandra.

---

### Command
Command används för att kapsla in handlingar som objekt, till exempel att tända en lampa eller ändra temperatur.  
Det gör att vi kan köa kommandon, köra dem i ordning och även köra om dem senare (replay).  

---

### Strategy
Strategy används för att hantera olika lägen i systemet, som NormalMode, EcoMode och PartyMode.  
Istället för att använda if-satser har varje mode sin egen klass, vilket gör det enklare att ändra och lägga till nya beteenden.

---

### Facade
Facade används för att förenkla hur systemet används från Program.cs.  
Istället för att hantera alla klasser direkt kan vi använda SmartHomeFacade som ett enkelt gränssnitt.  
Det gör att koden i main blir mycket renare.

---

### Singleton
Singleton används för loggern så att hela systemet använder samma instans.  
Det gör att all loggning sker på ett ställe och vi undviker att skapa flera olika logger-objekt.

---

## Exempel på körning

```text
--- NORMAL MODE ---
Living Room Lamp is ON
[NormalMode ⚙️] Living Room Lamp: Turned ON allowed
[Dashboard 📊] Living Room Lamp: Turned ON
[Audit 📝] Event saved for Living Room Lamp: Turned ON
[Logger 📄] Living Room Lamp: Turned ON

--- ECO MODE ---
[EcoMode 🌱] Living Room Lamp: power saving active

--- PARTY MODE ---
[PartyMode 🎉] Living Room Lamp: Turned ON fully allowed
