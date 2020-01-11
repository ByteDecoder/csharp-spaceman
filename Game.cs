using System;
using System.Linq;

namespace Spaceman {
  public class Game {
    public string Codeword { get; }

    public string CurrentWord { get; set; }
    public int MaxGuesses { get; }
    public int WrongGuesses { get; set; }

    public string[] Codewords => new[] {
      "pound", "antler", "cigarette", "colony", "beast", "naive", "racetrack",
      "mediocrity", "basque", "nautical", "cracked", "intern"
    };

    public Ufo Ufo => new Ufo();

    public Game() {
      var randomCodeword = new Random(Codewords.Length).Next();
      Codeword = Codewords[randomCodeword];
      MaxGuesses = 5;
      WrongGuesses = 0;
      CurrentWord = new string('_', Codeword.Length);
    }

    public void Greet() {
      Console.WriteLine("=============");
      Console.WriteLine("UFO: The Game");
      Console.WriteLine("=============");
      Console.WriteLine("Instructions: save your friend from alien abduction by guessing the letters in the codeword.");
    }

    public void Display() {
      Console.WriteLine(Ufo.Stringify());
      Console.WriteLine($"Current word: {CurrentWord}");
      Console.WriteLine($"Number guesses remaining: {MaxGuesses - WrongGuesses}");
    }

    public void Ask() {
      Console.Write("Enter your guess letter: ");
      var input = Console.ReadLine()?.ToLower();
      if(input == null) return;

      if(input.Length > 1) {
        Console.WriteLine("Only one letter at a time is valid.");
        return;
      }

      var contains = Codewords.Contains(input);
      var letter = input.ToCharArray()[0];
      if(contains) {
        CurrentWord = CurrentWord.Replace('_', letter);
      } else {
        Ufo.AddPart();
        WrongGuesses++;
      }
    }

    public bool DidWin() {
      return Codeword.Equals(CurrentWord);
    }

    public bool DidLose() {
      return WrongGuesses >= MaxGuesses;
    }
  }
}