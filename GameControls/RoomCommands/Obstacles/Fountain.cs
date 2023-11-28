using TheFountainOfObjects.TheFountainOfObjects;
using TheFountainOfObjects2.TheFountainOfObjects.GameCommands.RoomCommands;

namespace TheFountainOfObjects2.TheFountainOfObjects.GameControls.RoomCommands.Obstacles
{
    /// <summary>
    /// This Object has to be created first
    /// </summary>
    internal class Fountain : Obstacle, IActivate
    {
        GameRules game;
        public Fountain(GridSystem grid, Player instance, GameRules game) : base(grid, instance)
        {
            this.game = game;
            Start();
        }
        public void Start()
        {
            FindAvailableSpot();
            PlaceObstacle();
        }

        public void Room()
        {
            Console.Write("You found the fountain!! \n" +
                "Enable or Disable:");

            switch (Console.ReadLine().ToUpper())
            {
                case "ENABLE":
                    game.IsFountainEnable = true;
                    break;
                case "DISABLE":
                    game.IsFountainEnable = false;
                    break;
                default:
                    Room();
                    break;
            }
        }

        public override string ToString()
        {
            string name;
            return name = "Fountian";
        }
    }
}
