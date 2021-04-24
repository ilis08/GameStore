using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Data.Models
{
    public class ShopCart
    {
        private readonly GameStoreContext gameStoreContext;

        public ShopCart(GameStoreContext gameStoreContext)
        {
            this.gameStoreContext = gameStoreContext;
        }
        public string ShopCartId { get; set; }

        public List<ShopCartItem> listShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<GameStoreContext>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };
        }

        public void AddToCart(Game game)
        {
            gameStoreContext.ShopCartItems.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                game = game,
                Price = (int)game.Price
            });
            gameStoreContext.SaveChanges();
        }

        public List<ShopCartItem> GetShopItems()
        {
            return gameStoreContext.ShopCartItems.Where(c => c.ShopCartId == ShopCartId).Include(s => s.game).ToList();
        }
    }
}
