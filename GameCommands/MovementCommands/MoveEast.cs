using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TheFountainOfObjects.TheFountainOfObjects.GameCommands.MovementCommands
{
    internal class MoveEast : Commands
    {
        public override void Move(GridSystem grid, Player player)
        {
            if (player.LocationColumn > 0)
            {
                player.MoveWestEast(false);
            }
            else { Console.WriteLine("Can not move there!"); }
        }
    }
}
