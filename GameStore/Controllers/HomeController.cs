using GameStore.Data.Interfaces;
using GameStore.Data.Models;
using GameStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Controllers
{
    public class HomeController : Controller
    { 
        private readonly IAllGames _allGames;
        private readonly IGamesCategory _gamesCategory;
        public HomeController(IAllGames iAllGames, IGamesCategory iGamesCategory)
        {
            _allGames = iAllGames;
            _gamesCategory = iGamesCategory;
        }

        public IActionResult Index()
        {
            GamesListViewModel obj = new GamesListViewModel();
            obj.allGames = _allGames.Games;
            obj.gameCategory = "Games";
            return View(obj);
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
