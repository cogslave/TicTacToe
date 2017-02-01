using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TicTacToe.Library.Game;
using TicTacToe.Library.Player;
using TicTacToe.Library.Player.Random;
using Xunit;

namespace TicTacToe.Library.Tests.Player
{
    public class RandomPlayerTests
    {
        [Theory]
        [MemberData("Marks")]
        public void PlayersRespectsTheirGivenMark(Mark mark, GameState state)
        {
            var player = new RandomPlayer(new Random());
            player.SetMark(mark);
            player.Update(state);

            var move = player.NextMove();

            Assert.Equal(mark, move.Player);
        }
        
        public static IEnumerable<object[]> Marks
        {
            get
            {
                yield return new object[] { Mark.Noughts, new GameState(Outcome.Undetermined, new ReadOnlyCollection<TileState>(Enumerable.Repeat(TileState.Empty, 9).ToList())) };
                yield return new object[] { Mark.Crosses, new GameState(Outcome.Undetermined, new ReadOnlyCollection<TileState>(Enumerable.Repeat(TileState.Empty, 9).ToList())) };
            }
        }
    }
}