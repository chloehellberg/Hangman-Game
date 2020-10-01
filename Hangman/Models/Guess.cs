using System.Collections.Generic;

namespace Hangman.Models
{
  public class Guess
  {
    public string Letter { get; set; }
    private static List<Guess> _instances = new List<Guess> { };


    public Guess(string letter)
    {
      Letter = letter;
      _instances.Add(this);
    }

    public static List<Guess> GetAllGuesses()
    {
      return _instances;
    }
  }
}