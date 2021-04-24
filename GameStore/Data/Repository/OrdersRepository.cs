using GameStore.Data.Interfaces;
using GameStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly GameStoreContext gameStoreContext;
        private readonly ShopCart shopCart;

        public OrdersRepository(GameStoreContext gameStoreContext, ShopCart shopCart)
        {
            this.gameStoreContext = gameStoreContext;
            this.shopCart = shopCart;
        }
        public void createOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            gameStoreContext.Orders.Add(order);

            var items = shopCart.listShopItems;
            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    GameId = el.game.Id,
                    OrderId = order.Id,
                    Price = (int)el.game.Price
                };
                gameStoreContext.Orders.Add(order);
            }
            gameStoreContext.SaveChanges();
        }
        
    }
}
