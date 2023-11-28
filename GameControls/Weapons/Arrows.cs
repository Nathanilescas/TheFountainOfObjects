
using TheFountainOfObjects.TheFountainOfObjects.GameCommands;

namespace TheFountainOfObjects2.TheFountainOfObjects.GameControls.Weapons
{
    internal class Arrows : Commands
    {
        private int arrowsLeft = 3;
        public int ArrowsLeft
        {
            get { return arrowsLeft; }
            set { arrowsLeft = value; }
        }

    }
}
