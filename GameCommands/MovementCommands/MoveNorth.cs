
namespace TheFountainOfObjects.TheFountainOfObjects.GameCommands.MovementCommands
{
    internal class MoveNorth : Commands
    {
        private int row = 0;
        public override void Move(GridSystem grid, Player player)
        {
            if (player.LocationRow < grid.cavernGrid.GetLength(row))
            {
                player.MoveNorthSouth(true);
            }
            else { Console.WriteLine("Can not move there!"); }
        }
    }
}
