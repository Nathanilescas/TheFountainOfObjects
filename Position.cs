
namespace TheFountainOfObjects2.TheFountainOfObjects
{
    public struct Position
    {
        public int Row {  get; set; }
        public int Column { get; set; }

        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public void MoveNorthSouth(bool move)
        {
            Row += (move) ? 1 : -1;

        }
        public void MoveWestEast(bool move)
        {
            Column += (move) ? 1 : -1;
        }
    }
}
