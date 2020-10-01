using System.Collections.Generic;
using System;

namespace Hangman.Models
{
  public class Game
  {
    public string GameWord { get; set; }
    public int GuessesLeft { get; set; }
    public bool GoodOrBad { get; set; }

    private static List<Game> _instances = new List<Game> {};

    public Game()
    {
      GameWord = Game.GetWord();
      GuessesLeft = 6;
      GoodOrBad = false;
      _instances.Add(this);
    }

    public static string GetWord()
    {
      string[] words = { "jog", "dog", "sly" };
      Random random = new Random();
      int ran = random.Next(words.Length-1);
      return words[ran];
    }

    public static List<Game> GetAllGames()
    {
      return _instances;
    }
  }
}