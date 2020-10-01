using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Hangman.Models;

namespace Hangman.Controllers
{
  public class GameController : Controller
  {

    [HttpGet("/game")]
    public ActionResult Index()
    {
      List<Game> allGames = Game.GetAllGames();
      Game newestGame = allGames[allGames.Count-1];
      List<Guess> allGuesses = Guess.GetAllGuesses();
      string word = newestGame.GameWord;
      if (allGuesses.Count == 0)
      {
        return View(newestGame);
      }
      else
      {
        Guess latestGuess = allGuesses[allGuesses.Count-1];
        if (word.Contains(latestGuess.Letter))
        {
          newestGame.GoodOrBad = true;
          return View(newestGame);
        }
        else
        {
          newestGame.GoodOrBad = false;
          newestGame.GuessesLeft--;
          return View(newestGame);
        }
      }
      
      // Dictionary<string, object> model = new Dictionary<string, object>();
      // string word = Game.GetWord();
      // List<Guess> allGuesses = Guess.GetAllGuesses();
      // model.Add("word", word);
      // model.Add("guesses", allGuesses);
      // model.
      // return View();
    }

    [HttpPost("/game")]
    public ActionResult Create(string inputLetter)
    {
      Guess userGuess = new Guess(inputLetter);
      return RedirectToAction("Index");
    }

  }
}