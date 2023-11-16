
namespace TheFountainOfObjects.TheFountainOfObjects.GameCommands.MovementCommands;

internal class MoveWest : Commands
{
    private int column = 1;
    public override void Move(GridSystem grid, Player player)
    {
        if (player.LocationColumn < grid.cavernGrid.GetLength(column))
        {
            player.MoveWestEast(true);
        }
        else { Console.WriteLine("Can not move there!"); }
    }
}
