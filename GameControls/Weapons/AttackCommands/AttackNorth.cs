using TheFountainOfObjects.TheFountainOfObjects;
using TheFountainOfObjects.TheFountainOfObjects.GameCommands;

namespace TheFountainOfObjects2.TheFountainOfObjects.GameControls.Weapons.AttackCommands
{
    internal class AttackNorth : Commands
    {
        public override void Shoot(GridSystem grid, Player instance)
        {
            Position position = new Position();
            position = instance.playerPos;

            if (position.Row < grid.cavernGrid.GetLength(0) - 1)
            {
                position.Row += 1;

                if (grid.cavernGrid[position.Row, position.Column] != null)
                {
                    StopConsoleColor($"Destroyed {grid.cavernGrid[position.Row, position.Column]}");
                    grid.cavernGrid[position.Row, position.Column] = null;
                }
                else Console.WriteLine("Missed");
            }
        }
    }
}
