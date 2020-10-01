using Microsoft.AspNetCore.Mvc;
using Hangman.Models;

namespace Hangman.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        Guess.ClearGuesses();
        Game newGame = new Game();
        return View();
      }

    }
}