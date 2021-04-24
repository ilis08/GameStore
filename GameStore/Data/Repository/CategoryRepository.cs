using GameStore.Data.Interfaces;
using GameStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Data.Repository
{
    public class CategoryRepository : IGamesCategory
    {
        private readonly GameStoreContext gameStoreContext;

        public CategoryRepository(GameStoreContext gameStoreContext)
        {
            this.gameStoreContext = gameStoreContext;
        }
        public IEnumerable<Category> AllCategories => gameStoreContext.Category;
    }
}
