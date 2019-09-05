using Microsoft.AspNetCore.Mvc;

namespace Game.Controllers
{
    public class GameController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}
