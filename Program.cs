using System;

namespace Spaceman {
  internal class Program {
    private static void Main() {
      var game = new Game();

      game.Greet();
      do {
        game.Display();
        game.Ask();
      } while(game.DidWin() || game.DidLose());

      Console.WriteLine(game.DidWin() ? "You win" : "You Lose");
    }
  }
}
