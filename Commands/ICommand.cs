using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeHub.Commands
{   
    // skapar ett interface för kommandon, som kommer att implementeras av alla konkreta kommandoklasser. Det innehåller en metod Execute() som kommer att utföra den specifika åtgärden när den anropas.
    public interface ICommand
    {
        void Execute();
    }
}
