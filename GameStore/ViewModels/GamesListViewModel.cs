using GameStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.ViewModels
{
    public class GamesListViewModel
    {
        public IEnumerable<Game> allGames { get; set; }

        public string gameCategory { get; set; }
    }
}
