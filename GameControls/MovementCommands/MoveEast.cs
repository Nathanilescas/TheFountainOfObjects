
namespace TheFountainOfObjects.TheFountainOfObjects.GameCommands.MovementCommands
{
    internal class MoveEast : Commands
    {
        public override void Move(GridSystem grid, Player player)
        {
            if (player.playerPos.Column > 0)
            {
                player.playerPos.MoveWestEast(false);
            }
            else
            {
                StopConsoleColor("You can not move there!!");
                Thread.Sleep(1000);
            }
        }
    }
}
