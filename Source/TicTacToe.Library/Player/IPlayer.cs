using TicTacToe.Library.Game;

namespace TicTacToe.Library.Player
{
    public interface IPlayer
    {
        void SetMark(Mark mark);
        void Update(GameState state);
        Move NextMove();
    }
}