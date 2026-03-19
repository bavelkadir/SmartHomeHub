using System;
using System.Collections.Generic;
using System.Text;
using SmartHomeHub.Commands;


    namespace SmartHomeHub.Core
    {
        public class CommandInvoker
        {   
            // skapar en kö för att lagra kommandon som ska utföras och en lista för att hålla historiken av utförda kommandon
            private Queue<ICommand> commandQueue = new Queue<ICommand>();
            private List<ICommand> history = new List<ICommand>();
            
            // skapar en metod AddCommand() som tar emot ett ICommand-objekt som parameter och lägger till det i kommandokön. Detta gör att kommandon kan samlas in och utföras senare när ExecuteCommands() anropas.
            public void AddCommand(ICommand command)
            {
                commandQueue.Enqueue(command);
            }


            // skapar en metod ExecuteCommands() som utför alla kommandon i kön. För varje kommando som utförs, läggs det till i historiken. För att begränsa historiken till de senaste 5 kommandona, kontrolleras längden på historiken och det äldsta kommandot tas bort om den överstiger 5
            public void ExecuteCommands()
            {
                while (commandQueue.Count > 0)
                {
                    var command = commandQueue.Dequeue();
                    command.Execute();

                    history.Add(command);

                    // spara bara senaste 5
                    if (history.Count > 5)
                    {
                        history.RemoveAt(0);
                    }
                }
            }
            
            // skapar en metod ReplayLastCommands() som itererar genom historiken av utförda kommandon och anropar Execute() på varje kommando. Detta gör att användaren kan återupprepa de senaste kommandona som har utförts.
            public void ReplayLastCommands()
            {
                foreach (var command in history)
                {
                    command.Execute();
                }
            }
        }
    }
