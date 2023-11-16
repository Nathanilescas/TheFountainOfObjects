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
                    Console.Write("Do you want a large, medium, or small map? ");
                    string answer = Console.ReadLine();

                    int mapSize = (answer.ToUpper()) switch
                    {
                        "LARGE" => 8,
                        "MEDIUM" => 6,
                        "SMALL" => 4
                    };

                    int numberOfRows = mapSize;
                    int numberOfColumns = mapSize;
                    instance = new GridSystem(numberOfRows, numberOfColumns);
                }
                return instance;
            }
        }
        private GridSystem(int y, int x)
        {
            cavernGrid = new Commands[y, x];
            cavernGrid[0, (cavernGrid.GetLength(1) / 2)] = new Fountain();
        }
    }
}
