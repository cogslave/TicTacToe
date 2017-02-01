namespace TicTacToe.Library.Game
{
    public class Move
    {
        public CellIndex Index { get; }
        public Mark Player { get; }

        public Move(Mark player, CellIndex index)
        {
            Player = player;
            Index = index;
        }
    }
}