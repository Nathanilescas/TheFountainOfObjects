

using System.Text;

namespace TheFountainOfObjects.TheFountainOfObjects
{
    internal class GameRules 
    {
        private bool isAlive = true;

        private bool isFountainEnable =  false;
        public bool IsAlive
        {
            get { return isAlive ; }
            set { isAlive = value; }
        }
        public bool IsFountainEnable
        {
            get { return isFountainEnable; }
            set { isFountainEnable = value;}
        }

        public bool GameCheck(Player instance)
        {
            if ( instance.playerPos.Row == 0 && instance.playerPos.Column == 0)
            {
                if(isFountainEnable) return true;
            }
            return false;
        }
    }
}
