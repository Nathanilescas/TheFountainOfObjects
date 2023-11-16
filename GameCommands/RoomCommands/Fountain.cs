using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFountainOfObjects.TheFountainOfObjects.GameCommands.RoomCommands
{
    internal class Fountain : Commands
    {

        public override void ActivateRoom()
        {
            Console.WriteLine("Fountian is Active");
        }
    }
}
