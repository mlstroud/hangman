using Microsoft.AspNetCore.Mvc;
using Hangman.Models;

namespace Hangman.Controllers
{
  public class GameController : Controller
  {
    [HttpGet("/game")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/game/start")]
    public ActionResult Start()
    {
      Game game = new Game();
      return View("Index", game);
    }

    [HttpPost("/game")]
    public ActionResult Guess(char guess)
    {
      Game.Guess(guess);
      return View("Index");
    }
  }
}