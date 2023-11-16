using TheFountainOfObjects.TheFountainOfObjects.GameCommands;
using TheFountainOfObjects.TheFountainOfObjects.GameCommands.MovementCommands;
using TheFountainOfObjects.TheFountainOfObjects.GameCommands.RoomCommands;

namespace TheFountainOfObjects.TheFountainOfObjects
{
    internal class GridSystem
    {
        public readonly Commands[,] cavernGrid;
        private static GridSystem instance;
        public static GridSystem Instance
        {
            get
            {
                if (instance == null)
                {
                    int numberOfRows = 3;
                    int numberOfColumns = 3;
                    instance = new GridSystem(numberOfRows, numberOfColumns);
                }
                return instance;
            }
        }
        private GridSystem(int y, int x)
        {
            cavernGrid = new Commands[y, x];
            cavernGrid[0, 2] = new Fountain();
        }
    }
}
