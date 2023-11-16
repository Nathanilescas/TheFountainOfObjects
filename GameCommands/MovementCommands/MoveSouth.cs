
namespace TheFountainOfObjects.TheFountainOfObjects.GameCommands.MovementCommands
{
    internal class MoveSouth : Commands
    {
        public override void Move(GridSystem grid, Player player)
        {
            if (player.LocationRow > 0)
            {
                player.MoveNorthSouth(false);
            }
            else { Console.WriteLine("Can not move there!"); }
        }
    }
}
