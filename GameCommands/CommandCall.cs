

using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using TheFountainOfObjects.TheFountainOfObjects.GameCommands.RoomCommands;

namespace TheFountainOfObjects.TheFountainOfObjects.GameCommands.MovementCommands
{
    internal class CommandCall
    {
        public GridSystem Grid { get; set; }
        public Player Player { get; set; }
        public GameRules Rules { get; set; }


        public void RoomCommand()
        {

            if (Grid.cavernGrid[Player.LocationRow, Player.LocationColumn] != null)
            {
                Grid.cavernGrid[Player.LocationRow, Player.LocationColumn].ActivateRoom();
            }
            
        }

        

        public void CallMovementCommand(string input)
        {
            // put a try & catch here for the input to make sure that the user inputs one of the options
            Commands command = input.ToUpper() switch
            {
                "NORTH" => new MoveNorth(),
                "SOUTH" => new MoveSouth(),
                "WEST" => new MoveWest(),
                "EAST" => new MoveEast()
            };

            command.Move(Grid, Player);
        }


    }
}

