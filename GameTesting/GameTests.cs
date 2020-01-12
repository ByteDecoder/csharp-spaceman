using Spaceman;
using Xunit;

namespace GameTesting {
  public class GameTests {
    [Fact]
    public void NotNullInstance() {
      var game = new Game();
      Assert.NotNull(game);
    }
  }
}
