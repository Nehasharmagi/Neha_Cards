using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcNeha_Cards.Controllers
{
    public class PlayingCardsController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}