using TheFountainOfObjects.TheFountainOfObjects;
using TheFountainOfObjects2.TheFountainOfObjects.GameCommands.RoomCommands;

namespace TheFountainOfObjects2.TheFountainOfObjects.GameControls.RoomCommands.Obstacles
{
    internal class Maelstrom : Obstacle, IActivate
    {

        public Maelstrom(GridSystem grid, Player instance) : base(grid, instance)
        {
            Start();
        }

        public void Room()
        {
            FindAvailableSpot();
            Instance.playerPos.Row = this.ObstaclePos.Row;
            Instance.playerPos.Column = this.ObstaclePos.Column;

            FindAvailableSpot();
            PlaceObstacle();
        }

        public void Start()
        {
            FindAvailableSpot();
            PlaceObstacle();
        }

        public override string ToString()
        {
            string name;
            return name = "Maelstrom";
        }

    }
}
