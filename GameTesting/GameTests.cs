using Spaceman;
using Xunit;

namespace GameTesting {
  public class GameTests {
    [Fact]
    public void NotNullInstance() {
      var game = new Game();
      Assert.NotNull(game);
    }

    [Fact]
    public void GameFinalizersCheckDefaults() {
      var game = new Game();
      Assert.False(game.DidLose());
      Assert.False(game.DidWin());
    }

    [Fact]
    public void WinGame() {
      var game = new Game();
      var codeword = game.Codeword;
      game.CurrentWord = codeword;
      Assert.True(game.DidWin());
    }

    [Fact]
    public void LoseGame() {
      var game = new Game();
      game.WrongGuesses = game.MaxGuesses;
      Assert.True(game.DidLose());
    }
  }
}
