using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Data.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }
        public Game game { get; set; }
        public int Price { get; set; }

        public string ShopCartId { get; set; }
    }
}
