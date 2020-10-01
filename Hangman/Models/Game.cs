using System.Collections.Generic;

namespace Hangman.Models
{
  public class Game
  {
  
    public string[] words = { "jog", "dog", "sly" };

    public string GameWord { get; set; }

    public Game()
    {
      GameWord = Game.GetWord();
    }

    public static string GetWord()
    {
      Random random = new Random();
      int ran = random.Next(words.Length-1);
      return words[ran];
    }

  }
}