using System;
using CUT;
using Xunit;

namespace GameTest
{
    #region Zad.6 - Rozwiązanie
    public class GameTest
    {
        //sprawdzenie czy gra sie inicjuj poprawnie
        [Fact]
        public void Validate_game_initialization()
        {
            var game = new Game();

            Assert.False(game.IsGameOver);

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Assert.False(game.IsXMarkAtPosition(row, col));
                    Assert.False(game.IsOMarkAtPosition(row, col));
                }
            }
        }

        //sprawdzenie czy znaczki sie poprawnie wstawiaja
        [Fact]
        public void Check_set_x_at_given_position()
        {
            var game = new Game();

            game.PlaceXMarkAtPosition(1, 1);

            Assert.True(game.IsXMarkAtPosition(1, 1));
            Assert.False(game.IsOMarkAtPosition(1, 1));
        }

        [Fact]
        public void Check_set_o_at_given_position()
        {
            var game = new Game();

            game.PlaceOMarkAtPosition(2, 0);

            Assert.True(game.IsOMarkAtPosition(2, 0));
            Assert.False(game.IsXMarkAtPosition(2, 0));
        }

        //sprawdzenie czy kod poprawnie wylapie wychodzenie poza zakres
        //przy postawieniu znaku X
        [Theory]
        [InlineData(-1, 0)]
        [InlineData(3, 0)]
        [InlineData(0, -1)]
        [InlineData(0, 3)]
        public void PlaceXMarkAtPosition_out_of_range(int row, int col)
        {
            var game = new Game();

            Assert.Throws<GameException>(() => game.PlaceXMarkAtPosition(row, col));
        }
        //znaku O
        [Theory]
        [InlineData(-1, 0)]
        [InlineData(3, 0)]
        [InlineData(0, -1)]
        [InlineData(0, 3)]
        public void PlaceOMarkAtPosition_out_of_range(int row, int col)
        {
            var game = new Game();

            Assert.Throws<GameException>(() => game.PlaceOMarkAtPosition(row, col));
        }

        //przy sprawdzaniu czy na pozycji jest X
        [Theory]
        [InlineData(-1, 0)]
        [InlineData(3, 0)]
        [InlineData(0, -1)]
        [InlineData(0, 3)]
        public void IsXMarkAtPosition_out_of_range(int row, int col)
        {
            var game = new Game();

            Assert.Throws<GameException>(() => game.IsXMarkAtPosition(row, col));
        }
        //jest O
        [Theory]
        [InlineData(-1, 0)]
        [InlineData(3, 0)]
        [InlineData(0, -1)]
        [InlineData(0, 3)]
        public void IsOMarkAtPosition_out_of_range(int row, int col)
        {
            var game = new Game();

            Assert.Throws<GameException>(() => game.IsOMarkAtPosition(row, col));
        }

        //sprawdzenie czy da sie nadpisac znak 
        [Fact]
        public void PlaceMarkAtOccupiedPosition_ThrowsGameException()
        {
            var game = new Game();

            game.PlaceXMarkAtPosition(1, 1);

            var ex = Assert.Throws<GameException>(() => game.PlaceOMarkAtPosition(1, 1));
            Assert.Contains("not empty", ex.Message);
        }

        //sprawdzanie czy gra sie wygrywa kiedy trzeba
        [Fact]
        public void Three_x_in_row()
        {
            var game = new Game();

            game.PlaceXMarkAtPosition(0, 0);
            game.PlaceXMarkAtPosition(0, 1);
            game.PlaceXMarkAtPosition(0, 2);

            Assert.True(game.IsGameOver);
        }

        [Fact]
        public void Three_o_in_column()
        {
            var game = new Game();

            game.PlaceOMarkAtPosition(0, 1);
            game.PlaceOMarkAtPosition(1, 1);
            game.PlaceOMarkAtPosition(2, 1);

            Assert.True(game.IsGameOver);
        }

        [Fact]
        public void Three_x_in_diagonal()
        {
            var game = new Game();

            game.PlaceXMarkAtPosition(0, 0);
            game.PlaceXMarkAtPosition(1, 1);
            game.PlaceXMarkAtPosition(2, 2);

            Assert.True(game.IsGameOver);
        }
    }
    #endregion
}

