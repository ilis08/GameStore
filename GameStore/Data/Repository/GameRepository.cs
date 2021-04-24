using GameStore.Data;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using GameStore.Data.Interfaces;
using GameStore.Data.Models;

namespace GameStore.Data.Repository
{
    public class GameRepository : IAllGames
    {
        private readonly GameStoreContext gameStoreContext;

        public GameRepository(GameStoreContext gameStoreContext)
        {
            this.gameStoreContext = gameStoreContext;
        }
        
        public IEnumerable<Game> Games => gameStoreContext.Game.Include(c => c.Category);

        public IEnumerable<Game> GetFavGames => gameStoreContext.Game.Where(p => p.IsFavourite).Include(c => c.Category);


        public Game getObjectGame(int gameId) => gameStoreContext.Game.FirstOrDefault(p => p.Id == gameId);
        
    }
}
