using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RetroRent.Models;
//using RetroRent.ViewModels;

namespace RetroRent.Controllers
{
    public class GamesController : Controller
    {
       
        public ActionResult Index()
        {
            var game = GetGames();

            return View(game);
        }
        
        private IEnumerable<Game> GetGames()
        {
            return new List<Game>
            {
                new Game { ID = 1, Name = "Castlevania 2",Platform ="NES" },
                new Game { ID = 2, Name = "Megaman 2",Platform="NES" },
                new Game { ID = 2, Name = "Sonic The Hedgehog",Platform="SEGA" },
                new Game { ID = 2, Name = "Punch Out",Platform="NES" }

            };
        } 

          
      
    }
}