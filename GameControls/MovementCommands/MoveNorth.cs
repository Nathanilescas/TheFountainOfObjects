
namespace TheFountainOfObjects.TheFountainOfObjects.GameCommands.MovementCommands
{
    internal class MoveNorth : Commands
    {
        private int row = 0;
        public override void Move(GridSystem grid, Player player)
        {
            if (player.playerPos.Row < grid.cavernGrid.GetLength(row) - 1)
            {
                player.playerPos.MoveNorthSouth(true);
            }
            else { StopConsoleColor("You can not move there!!"); }
        }
    }
}
