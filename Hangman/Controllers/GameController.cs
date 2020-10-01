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
      List<Guess> allGuesses = Guess.GetAllGuesses();
      return View(allGuesses);
    }

    [HttpPost("/game")]
    public ActionResult Create(string inputLetter)
    {
      Guess userGuess = new Guess(inputLetter);
      return RedirectToAction("Index");
    }

  }
}