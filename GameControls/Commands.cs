using TheFountainOfObjects2.TheFountainOfObjects;

namespace TheFountainOfObjects.TheFountainOfObjects.GameCommands
{
    internal abstract class Commands
    {
        public virtual void Move(GridSystem cavernGrid, Player playerLocation)
        {

        }
        public virtual void Shoot(GridSystem cavernGrid, Player instance)
        {

        }


        public void StopConsoleColor(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(text);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
