using Microsoft.AspNetCore.Mvc;
using LeetSpeakApp.Models;
using System;

namespace LeetSpeakApp.Controllers
{
    public class HomeController : Controller
    {
      [Produces("text/html")]
      [HttpGet("/")]
      public ActionResult Index()
      {
      return View();
      }


      [HttpGet("/form")]
      public ActionResult Form()
      {
        return View();
      }

      [HttpPost("/")]
      public ActionResult Return()
      {
        string userSentence = (Request.Form["phrase"]);
        string convertedSentence = LeetSpeak.LeetTranslate(userSentence);
        return View("Index", convertedSentence);
      }
    }
}
