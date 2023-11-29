using TheFountainOfObjects.TheFountainOfObjects;
using TheFountainOfObjects2.TheFountainOfObjects.GameControls.RoomCommands;

namespace TheFountainOfObjects2.TheFountainOfObjects.GameCommands.RoomCommands
{
    internal abstract class Obstacle 
    {
        private Position obstaclePos;
        public Position ObstaclePos
        {
            get { return obstaclePos; }
        }

        public GridSystem Grid { get; }
        public Player Instance { get; }


        public Obstacle(GridSystem grid, Player instance)
        {
            Grid = grid;
            Instance = instance;
        }

        public void RemoveObstacle()
        {
            Grid.cavernGrid[ObstaclePos.Row, ObstaclePos.Column] = null;
        }
        public void PlaceObstacle()
        {
            Grid.cavernGrid[ObstaclePos.Row, ObstaclePos.Column] = (IActivate)this;
        }
        public void FindAvailableSpot()
        {
            Random randomNum = new Random();
            while (true)
            {
                int randomRow = randomNum.Next(2, Grid.cavernGrid.GetLength(0));
                int randomColumn = randomNum.Next(2, Grid.cavernGrid.GetLength(1));

                if (Grid.cavernGrid[randomRow, randomColumn] == null)
                {
                    this.obstaclePos.Row = randomRow;
                    this.obstaclePos.Column = randomColumn;
                    break;
                }
            }
        }


        // This checks all 8 surrounding blocks
        internal void Check360Pos()
        {
            CheckDiagonalPos();
            CheckVHPos();
        }


        // This Checks the Diagonal coordinates
        internal void CheckDiagonalPos()
        {
            if ((ObstaclePos.Row - 1) == Instance.playerPos.Row || (ObstaclePos.Row + 1) == Instance.playerPos.Row)
            {
                if ((ObstaclePos.Column - 1) == Instance.playerPos.Column || (ObstaclePos.Column + 1) == Instance.playerPos.Column)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"The {this.ToString()} is near by!!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }


        // This Check the Vertical and horizontal coordinates
        internal void CheckVHPos()
        {
            bool isMatch = false;
            
            if (Instance.playerPos.Row == ObstaclePos.Row)
            {
                isMatch = (Instance.playerPos.Column == ObstaclePos.Column + 1 || Instance.playerPos.Column == ObstaclePos.Column - 1);
            }
            else if (Instance.playerPos.Column == ObstaclePos.Column)
            {
                isMatch = (Instance.playerPos.Row == ObstaclePos.Row + 1 || Instance.playerPos.Row == ObstaclePos.Row - 1);
            }
            
            if (isMatch)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The {this.ToString()} is near by!!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

        }
    }
}

 