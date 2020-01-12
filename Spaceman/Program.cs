using System;

namespace Spaceman {
  internal class Program {
    private static void Main() {
      var game = new Game();

      game.Greet();
      while(true) {
        game.Display();
        game.Ask();
        if(game.DidWin() || game.DidLose()) break;
      }

      Console.WriteLine(game.DidWin() ? "You win" : "You Lose");
    }
  }
}
