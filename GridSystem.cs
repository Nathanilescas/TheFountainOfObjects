using TheFountainOfObjects2.TheFountainOfObjects.GameCommands.RoomCommands;
using TheFountainOfObjects2.TheFountainOfObjects.GameControls.RoomCommands;

namespace TheFountainOfObjects.TheFountainOfObjects
{
    internal class GridSystem
    {
        private static GridSystem instance;
        public static GridSystem Instance
        {
            get
            {
                if (instance == null)
                {
                    Console.Write("Do you want a large, medium, or small map? ");
                    string answer = Console.ReadLine();
                    Console.Clear();
                    int mapSize;
                    try
                    {
                        mapSize = (answer.ToUpper()) switch
                        {
                            "LARGE" => 8,
                            "MEDIUM" => 6,
                            "SMALL" => 4,
                            _ => throw new Exception("Invalid Input!")
                        };
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message + "\nMap size will be 3x3.\n");
                        mapSize = 4;
                    }
                    instance = new GridSystem(mapSize, mapSize);

                }
                return instance;
            }
        }

        public readonly IActivate[,] cavernGrid;
       
        private GridSystem(int Row, int Col) 
        {
            cavernGrid = new IActivate[Row, Col];            
        } 
    }
}
