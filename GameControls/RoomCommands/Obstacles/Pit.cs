using System.Diagnostics;
using TheFountainOfObjects.TheFountainOfObjects;
using TheFountainOfObjects2.TheFountainOfObjects.GameCommands.RoomCommands;

namespace TheFountainOfObjects2.TheFountainOfObjects.GameControls.RoomCommands.Obstacles
{
    internal class Pit : Obstacle, IActivate
    {

        public Pit(GridSystem grid, Player instance) : base(grid, instance)
        {
            Start();
        }

        public void Room()
        {
            Instance.playerPos.Row = 0;
            Instance.playerPos.Column = 0;
            Console.WriteLine($"You new position is: ({Instance.playerPos.Row}, {Instance.playerPos.Column})");
        }

        public void Start()
        {
            FindAvailableSpot();
            PlaceObstacle();
        }

        public override string ToString()
        {
            string name;
            return name = "Pit";
        }

    }
}
