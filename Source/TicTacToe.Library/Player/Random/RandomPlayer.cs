using System.Linq;
using TicTacToe.Library.Extentions;
using TicTacToe.Library.Game;

namespace TicTacToe.Library.Player.Random
{
    public class RandomPlayer : IPlayer
    {
        private readonly System.Random _random;
        private Mark _mark;
        private GameState _state;

        public RandomPlayer(System.Random random)
        {
            _random = random;
        }

        public void SetMark(Mark mark)
        {
            _mark = mark;
        }

        public void Update(GameState state)
        {
            _state = state;
        }

        public Move NextMove()
        {
            var index = (CellIndex)_state.Tiles
                .Select((x, i) => new { Index = i, TileState = x })
                .Where(x => x.TileState == TileState.Empty)
                .Shuffle(_random)
                .First()
                .Index;

            return new Move(_mark, index);
        }
    }
}