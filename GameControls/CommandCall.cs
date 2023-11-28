using TheFountainOfObjects2.TheFountainOfObjects.GameControls.Weapons.AttackCommands;

namespace TheFountainOfObjects.TheFountainOfObjects.GameCommands.MovementCommands
{
    internal class CommandCall
    {
        private GridSystem Grid { get; set; } // Need a reference to the grid 
        private Player Player { get; set; } // Need a reference to the player
        //public GameRules Rules { get; set; }


        public CommandCall(GridSystem grid, Player player)
        {
            Grid = grid;
            Player = player;
        }

        public void LandedOnRoom()
        {
            if (Grid.cavernGrid[Player.playerPos.Row, Player.playerPos.Column] != null)
            {
                Grid.cavernGrid[Player.playerPos.Row, Player.playerPos.Column].Room();
            }
        }


        public void ChooseCommand()
        {
            Console.Write("What do you want to do? ");
            string input = Console.ReadLine();

            switch(input.ToUpper())
            {
                case "MOVE": Movement();
                    break;
                case "ATTACK": ShootArrow();
                    break;
                default: Console.WriteLine("Choose: Move or Attack");
                    break;
            }
        }

        public void Movement()
        {
            Console.Write("==========================\n" +
                "Move: ");
            Console.WriteLine($"({Player.playerPos.Row}, {Player.playerPos.Column})");
            string input = Console.ReadLine();

            // put a try & catch here for the input to make sure that the user inputs one of the options
            Commands command = input.ToUpper() switch
            {
                "NORTH" => new MoveNorth(),
                "SOUTH" => new MoveSouth(),
                "WEST" => new MoveWest(),
                "EAST" => new MoveEast()
            };

            command.Move(Grid, Player);
            Console.WriteLine($"({Player.playerPos.Row}, {Player.playerPos.Column})");

        }


        public void ShootArrow()
        {
            Console.Write("Attack: ");
            //// PUT TRY AND CATCH HERE !!!!!!!!!!!!!
            string input = Console.ReadLine();

            Commands command = input.ToUpper() switch
            {
                "NORTH" => new AttackNorth(),
                "SOUTH" => new AttackSouth(),
                "WEST" => new AttackWest(),
                "EAST" => new AttackEast()
            };

            command.Shoot(Grid, Player);
        }

    }
}