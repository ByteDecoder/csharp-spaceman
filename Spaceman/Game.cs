using System;
using System.Collections.Generic;

namespace Spaceman {
  public class Game {
    private readonly List<char> _guessedLetters = new List<char>();
    public string Codeword { get; }

    public string CurrentWord { get; set; }
    public int MaxGuesses { get; }
    public int WrongGuesses { get; set; }

    public string[] Codewords => new[] {
      "pound", "antler", "cigarette", "colony", "beast", "naive", "racetrack",
      "mediocrity", "basque", "nautical", "cracked", "intern"
    };

    public Ufo Ufo { get; }

    public Game() {
      var randomCodeword = new Random().Next(Codewords.Length);
      Codeword = Codewords[randomCodeword];
      MaxGuesses = 5;
      WrongGuesses = 0;
      CurrentWord = new string('_', Codeword.Length);
      Ufo = new Ufo();
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
      if(_guessedLetters.Count > 0) {
        Console.WriteLine($"Already typed letters in thi game session: ");
        _guessedLetters.ForEach(item => Console.Write($" {item} "));
        Console.WriteLine("");
      }

      Console.Write("Enter your guess letter: ");
      var input = Console.ReadLine()?.ToLower();
      if(input == null) return;

      if(input.Length > 1) {
        Console.WriteLine("Only one letter at a time is valid.");
        return;
      }

      var contains = Codeword.Contains(input);
      var letter = input.ToCharArray()[0];

      if(_guessedLetters.Contains(letter)) {
        Console.WriteLine($"You already typed the ({input}) letter, try another one...");
        return;
      }

      if(contains) {
        var currentIndex = 0;
        while(true) {
          var index = Codeword.IndexOf(letter, currentIndex);
          if(index == -1) break;
          currentIndex = index + 1;
          CurrentWord = CurrentWord.Remove(index, 1).Insert(index, letter.ToString());
        }
      } else {
        Ufo.AddPart();
        WrongGuesses++;
      }
      _guessedLetters.Add(letter);
    }

    public bool DidWin() {
      return Codeword.Equals(CurrentWord);
    }

    public bool DidLose() {
      return WrongGuesses >= MaxGuesses;
    }
  }
}