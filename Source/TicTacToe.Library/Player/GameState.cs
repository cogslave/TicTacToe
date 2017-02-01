using System.Collections.Generic;
using TicTacToe.Library.Game;

namespace TicTacToe.Library.Player
{
    public class GameState
    {
        public Outcome Outcome { get; }
        public IReadOnlyCollection<TileState> Tiles{ get; }

        public GameState(Outcome outcome, IReadOnlyCollection<TileState> tiles)
        {
            Outcome = outcome;
            Tiles = tiles;
        }
    }
}