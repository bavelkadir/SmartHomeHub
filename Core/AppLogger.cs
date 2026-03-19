using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeHub.Core
{
    public class AppLogger
    {

        private static AppLogger instance;

        // koden neda är privat för att förhindra att andra klasser kan skapa instanser av AppLogger-klassen, så att vi kan säkerställa att det bara finns en enda instans av loggaren i hela appen
        private AppLogger()
        {
            Console.WriteLine("AppLogger instance created");
        }

        // koden nedan skapar en statisk egenskap som returnerar den enda instansen av AppLogger-klassen, så att vi kan använda den för att logga meddelanden i hela appen utan att behöva skapa flera instanser av loggaren
        public static AppLogger Instance
        {

            // koden nedan kontrollerar om instansen av AppLogger redan har skapats, och om inte, så skapar den en ny instans. Sedan returnerar den instansen, så att vi kan använda den för att logga meddelanden i hela appen
            get
            {
                if (instance == null)
                {

                    instance = new AppLogger();

                }

                return instance;


            }
        }

        // koden nedan skapar en metod för att logga meddelanden, så att vi kan hålla reda på vad som händer i appen och felsöka eventuella problem
        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {DateTime.Now}: {message}");
        }




    }
}