using TheFountainOfObjects2.TheFountainOfObjects.GameControls.Weapons.AttackCommands;
using System.Threading;

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
            Commands command;
            try
            {
                command = input.ToUpper() switch
                {
                    "NORTH" => new MoveNorth(),
                    "SOUTH" => new MoveSouth(),
                    "WEST" => new MoveWest(),
                    "EAST" => new MoveEast(),
                    _ => throw new InvalidOperationException("\nInvalid Command!!")
                } ;
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Thread.Sleep(1500);
                command = null;
            }

            if (command != null)
            {
                command.Move(Grid, Player);
                Console.WriteLine($"({Player.playerPos.Row}, {Player.playerPos.Column})");
            }

        }


        public void ShootArrow()
        {
            Console.Write("==========================\n" +
                "Attack: ");
            //// PUT TRY AND CATCH HERE !!!!!!!!!!!!!
            string input = Console.ReadLine();
            Commands command;
            try
            {
                command = input.ToUpper() switch
                {
                    "NORTH" => new AttackNorth(),
                    "SOUTH" => new AttackSouth(),
                    "WEST" => new AttackWest(),
                    "EAST" => new AttackEast(),
                    _ => throw new InvalidOperationException("\nInvalid Command!!")
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Thread.Sleep(1500);
                command = null;
            }

            if (command != null)
            {
                command.Shoot(Grid, Player);
            }
        }

    }
}