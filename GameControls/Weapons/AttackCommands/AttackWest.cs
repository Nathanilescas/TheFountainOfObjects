using TheFountainOfObjects.TheFountainOfObjects;
using TheFountainOfObjects.TheFountainOfObjects.GameCommands;

namespace TheFountainOfObjects2.TheFountainOfObjects.GameControls.Weapons.AttackCommands
{
    internal class AttackWest : Commands
    {
        public override void Shoot(GridSystem grid, Player instance)
        {
            Position position = new Position();
            position = instance.playerPos;

            if (position.Column < grid.cavernGrid.GetLength(1) - 1)
            {
                position.Column += 1;

                if (grid.cavernGrid[position.Row, position.Column] != null)
                {
                    StopConsoleColor($"Destroyed {grid.cavernGrid[position.Row, position.Column]}");
                    grid.cavernGrid[position.Row, position.Column] = null;
                }
                else
                {
                    Console.WriteLine("\nMissed");
                    Thread.Sleep(1500);
                }

            }
        }
    }
}
