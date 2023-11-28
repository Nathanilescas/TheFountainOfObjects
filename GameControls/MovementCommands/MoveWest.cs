
namespace TheFountainOfObjects.TheFountainOfObjects.GameCommands.MovementCommands;

internal class MoveWest : Commands
{
    private int column = 1;
    public override void Move(GridSystem grid, Player player)
    {
        if (player.playerPos.Column < grid.cavernGrid.GetLength(column) - 1)
        {
            player.playerPos.MoveWestEast(true);
        }
        else { StopConsoleColor("You can not move there!!"); }
    }
}
