using GameStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Data.Interfaces
{
    public interface IAllOrders
    {
        void createOrder(Order order);
        
    }
}
