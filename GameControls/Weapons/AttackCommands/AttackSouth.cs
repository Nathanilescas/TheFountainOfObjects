
using TheFountainOfObjects.TheFountainOfObjects;
using TheFountainOfObjects.TheFountainOfObjects.GameCommands;

namespace TheFountainOfObjects2.TheFountainOfObjects.GameControls.Weapons.AttackCommands
{
    internal class AttackSouth : Commands
    {
        public override void Shoot(GridSystem grid, Player instance)
        {

            Position position = new Position();
            position = instance.playerPos;

            Console.BackgroundColor = ConsoleColor.DarkRed;


            if (position.Row > 0)
            {
                position.Row -= 1;

                if (grid.cavernGrid[position.Row, position.Column] != null)
                {
                    Thread.Sleep(1500);
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
