using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Hangman.Models;

namespace Hangman.Controllers
{
  public class GuessController : Controller
  {

    [HttpGet("/game/guess/new")]
    public ActionResult New()
    {
      return View();
    }

  }
}