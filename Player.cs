using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFountainOfObjects.TheFountainOfObjects
{
    internal class Player
    {
        private int locationRow = 0;
        private int locationColumn = 0;

        public int LocationRow
        {
            get { return locationRow; }

        }
        public int LocationColumn
        {
            get { return locationColumn; }
        }

        public void MoveNorthSouth(bool move)
        {
            locationRow += (move) ? 1 : -1 ;

        }
        public void MoveWestEast(bool move)
        {
            locationColumn += (move) ? 1 : -1;
        }
    }
}
