
namespace TheFountainOfObjects.TheFountainOfObjects.GameCommands.MovementCommands
{
    internal class MoveSouth : Commands
    {
        public override void Move(GridSystem grid, Player player)
        {
            if (player.playerPos.Row > 0)
            {
                player.playerPos.MoveNorthSouth(false);
            }
            else { StopConsoleColor("You can not move there!!"); }
        }
    }
}
