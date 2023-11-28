using TheFountainOfObjects.TheFountainOfObjects;
using TheFountainOfObjects2.TheFountainOfObjects.GameCommands.RoomCommands;

namespace TheFountainOfObjects2.TheFountainOfObjects.GameControls.RoomCommands.Obstacles
{
    internal class Amaroks : Obstacle, IActivate
    {
        GameRules Playing;


        public Amaroks(GameRules playing , GridSystem grid, Player instance) : base(grid, instance)
        {
            Playing = playing;
            Start();
        }

        public void Room()
        {
            Console.WriteLine("The Amarok striks you and Kills you!! \n" +
                "You Lost");
            Playing.IsAlive = false;
        }

        public void Start()
        {
            FindAvailableSpot();
            PlaceObstacle();
        }
        public override string ToString()
        {
            string name;
            return name = "Amaroks"; 
        }

    }
}
